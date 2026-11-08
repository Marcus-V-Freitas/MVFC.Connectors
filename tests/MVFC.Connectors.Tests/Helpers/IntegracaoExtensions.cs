namespace MVFC.Connectors.Tests.Helpers;

public static class IntegracaoExtensions
{
    public static void BeSuccessfulOrSkip(this ObjectAssertions assertions, string apiName)
    {
        var chain = assertions.CurrentAssertionChain;

        if (assertions.Subject is null)
        {
            chain.FailWith("BeSuccessfulOrSkip esperava um ApiResponse ou Exception, mas encontrou null.");
            return;
        }

        if (assertions.Subject is IApiResponse response)
        {
            if (response.IsSuccessful)
                return;

            var status = response.StatusCode;
            var is5xx = status >= HttpStatusCode.InternalServerError && status <= HttpStatusCode.NetworkAuthenticationRequired;
            response.HasResponseError(out var error);

            if (is5xx ||
                IsMensagemIndisponivel(response.Error?.Message) ||
                IsMensagemIndisponivel(error?.Content))
            {
                PularTeste(apiName, status);
            }

            chain
                .ForCondition(response.IsSuccessful)
                .FailWith("A chamada para {0} falhou com status {1} e erro: {2}",
                    apiName,
                    response.StatusCode,
                    error?.Content ?? response.Error?.Message ?? "Sem detalhes.");
            return;
        }

        if (assertions.Subject is Exception ex)
        {
            if (IsExcecaoIndisponivel(ex))
            {
                PularTeste(apiName);
            }

            chain.FailWith("A chamada para {0} lançou uma exceção inesperada: {1}", apiName, ex.Message);
            return;
        }

        chain.FailWith(
            "BeSuccessfulOrSkip não reconhece o tipo {0}. Use com ApiResponse ou Exception.",
            assertions.Subject.GetType().Name);
    }

    public static bool IsExcecaoIndisponivel(Exception? ex)
    {
        if (ex is null)
            return false;

        var name = ex.GetType().Name;
        if (name.Contains("SkipException", StringComparison.OrdinalIgnoreCase))
            return false;

        if (ex is AggregateException agg)
        {
            foreach (var inner in agg.InnerExceptions)
            {
                if (IsExcecaoIndisponivel(inner)) return true;
            }
        }

        if (name.Contains("Timeout", StringComparison.OrdinalIgnoreCase) ||
            ex is TaskCanceledException ||
            ex is HttpRequestException)
        {
            return true;
        }

        return IsMensagemIndisponivel(ex.Message) || IsExcecaoIndisponivel(ex.InnerException);
    }

    public static bool IsMensagemIndisponivel(string? message)
    {
        if (string.IsNullOrEmpty(message))
            return false;

        return message.Contains("502", StringComparison.OrdinalIgnoreCase) ||
               message.Contains("503", StringComparison.OrdinalIgnoreCase) ||
               message.Contains("504", StringComparison.OrdinalIgnoreCase) ||
               message.Contains("Service Unavailable", StringComparison.OrdinalIgnoreCase) ||
               message.Contains("Gateway Timeout", StringComparison.OrdinalIgnoreCase) ||
               message.Contains("timeout", StringComparison.OrdinalIgnoreCase) ||
               message.Contains("canceled", StringComparison.OrdinalIgnoreCase) ||
               message.Contains("indisponível", StringComparison.OrdinalIgnoreCase) ||
               message.Contains("unavailable", StringComparison.OrdinalIgnoreCase);
    }

    private static void PularTeste(string apiName, HttpStatusCode? status = null)
    {
        var msg = status.HasValue ? $" (Status: {status})" : "";
        Assert.Skip($"{apiName} parece indisponível ou lento no momento{msg}. O teste foi ignorado.");
    }
}

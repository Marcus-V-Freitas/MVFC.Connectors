using FluentAssertions.Execution;
using FluentAssertions.Primitives;

namespace MVFC.Connectors.Tests.Helpers;

public static class IntegracaoExtensions
{
    public static void BeSuccessfulOrSkip(this ObjectAssertions assertions, string apiName)
    {
        // Caso o objeto seja nulo, falha normalmente
        if (assertions.Subject == null)
        {
            Execute.Assertion
                .FailWith("BeSuccessfulOrSkip esperava um ApiResponse ou Exception, mas encontrou null.");
            return;
        }

        // Se for uma IApiResponse (Refit)
        if (assertions.Subject is IApiResponse response)
        {
            if (response.IsSuccessful) return;

            // Em barramentos de integração, 500+ costuma ser indisponibilidade externa
            var status = (int)response.StatusCode;
            var is5xx = status >= 500 && status <= 599;

            if (is5xx || IsMensagemIndisponivel(response.Error?.Message) || IsMensagemIndisponivel(response.Error?.Content))
            {
                PularTeste(apiName, status);
            }

            Execute.Assertion
                .ForCondition(response.IsSuccessful)
                .FailWith("A chamada para {0} falhou com status {1} e erro: {2}", 
                    apiName, 
                    response.StatusCode, 
                    response.Error?.Content ?? response.Error?.Message ?? "Sem detalhes.");
            return;
        }

        // Se caiu aqui, pode ser que o teste tenha capturado a exceção e passado para o Should()
        if (assertions.Subject is Exception ex)
        {
            if (IsExcecaoIndisponivel(ex))
            {
                PularTeste(apiName);
            }

            Execute.Assertion
                .FailWith("A chamada para {0} lançou uma exceção inesperada: {1}", apiName, ex.Message);
            return;
        }

        Execute.Assertion
            .FailWith("BeSuccessfulOrSkip não reconhece o tipo {0}. Use com ApiResponse ou Exception.", assertions.Subject.GetType().Name);
    }

    public static bool IsExcecaoIndisponivel(Exception? ex)
    {
        if (ex == null) return false;

        // Não queremos tratar o SkipException do xUnit como uma falha de indisponibilidade para não entrar em loop ou mascarar
        var name = ex.GetType().Name;
        if (name.Contains("SkipException", StringComparison.OrdinalIgnoreCase)) return false;

        // Se for AggregateException (comum em ContinueWith/Task.Wait), verifica as filhas
        if (ex is AggregateException agg)
        {
            foreach (var inner in agg.InnerExceptions)
            {
                if (IsExcecaoIndisponivel(inner)) return true;
            }
        }

        // Tipos de exceção ou códigos que indicam indisponibilidade externa
        if (name.Contains("Timeout", StringComparison.OrdinalIgnoreCase) || 
            ex is TaskCanceledException || 
            ex is HttpRequestException)
        {
            return true;
        }

        if (IsMensagemIndisponivel(ex.Message)) return true;

        return IsExcecaoIndisponivel(ex.InnerException);
    }

    public static bool IsMensagemIndisponivel(string? message)
    {
        if (string.IsNullOrEmpty(message)) return false;

        // Termos genéricos que indicam falha de infra/serviço externo
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

    private static void PularTeste(string apiName, int? status = null)
    {
        var msg = status.HasValue ? $" (Status: {status})" : "";
        Assert.Skip($"{apiName} parece indisponível ou lento no momento{msg}. O teste foi ignorado.");
    }
}

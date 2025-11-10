namespace MVFC.Connectors.Conversores.GoogleTradutor.Handlers;

internal sealed class GoogleTradutorHandler : DelegatingHandler
{
    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {

        var response = await base.SendAsync(request, cancellationToken);

        var conteudo = await response.Content.ReadAsStringAsync(cancellationToken);
        var textoTraduzido = ExtrairTraducao(conteudo);

        response.Content = new StringContent(textoTraduzido, Encoding.UTF8, "text/plain");

        return response;
    }

    private static string ExtrairTraducao(string json)
    {
        if (string.IsNullOrEmpty(json))
        {
            return string.Empty;
        }

        var detalhesExternos = JsonSerializer.Deserialize<List<object>>(json);
        var detalhesInternos = JsonSerializer.Deserialize<List<object>>($"{detalhesExternos!.FirstOrDefault()}");

        var sb = new StringBuilder();

        foreach (var detalheInterno in detalhesInternos!)
        {
            var dadoTraduzido = JsonSerializer.Deserialize<List<object>>($"{detalheInterno}");
            var textoTraduzido = $"{dadoTraduzido!.FirstOrDefault()}";

            if (!string.IsNullOrEmpty(textoTraduzido))
            {
                sb.Append(textoTraduzido);
            }
        }

        return sb.ToString();
    }
}
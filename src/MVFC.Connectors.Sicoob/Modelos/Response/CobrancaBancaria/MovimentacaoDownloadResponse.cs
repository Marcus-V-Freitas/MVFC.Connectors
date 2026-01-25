namespace MVFC.Connectors.Sicoob.Modelos.Response.CobrancaBancaria;

public sealed record MovimentacaoDownloadResponse(
    [property: JsonPropertyName("arquivo")] string Arquivo,
    [property: JsonPropertyName("nomeArquivo")] string NomeArquivo);
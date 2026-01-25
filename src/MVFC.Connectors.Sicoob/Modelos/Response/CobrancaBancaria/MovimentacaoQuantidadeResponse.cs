namespace MVFC.Connectors.Sicoob.Modelos.Response.CobrancaBancaria;

public sealed record MovimentacaoQuantidadeResponse(
    [property: JsonPropertyName("quantidadeTotalRegistros")] string QuantidadeTotalRegistros,
    [property: JsonPropertyName("quantidadeRegistrosArquivo")] int QuantidadeRegistrosArquivo,
    [property: JsonPropertyName("quantidadeArquivo")] int QuantidadeArquivo,
    [property: JsonPropertyName("idArquivos")] int[] IdArquivos);
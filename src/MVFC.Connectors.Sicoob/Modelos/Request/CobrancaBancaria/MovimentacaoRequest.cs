namespace MVFC.Connectors.Sicoob.Modelos.Request.CobrancaBancaria;

public sealed record MovimentacaoRequest(
    [property: JsonPropertyName("numeroCliente")] int NumeroCliente,
    [property: JsonPropertyName("tipoMovimento")] TipoMovimento TipoMovimento,
    [property: JsonPropertyName("dataInicial")] DateOnly DataInicial,
    [property: JsonPropertyName("dataFinal")] DateOnly DataFinal);
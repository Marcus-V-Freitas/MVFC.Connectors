namespace MVFC.Connectors.Financas.Bcb.Modelos.Request;

public record BbcRequest(
    [property: JsonPropertyName("tamanhoPagina")] int TamanhoPagina = 20,
    [property: JsonPropertyName("numeroPagina")] int NumeroPagina = 0);
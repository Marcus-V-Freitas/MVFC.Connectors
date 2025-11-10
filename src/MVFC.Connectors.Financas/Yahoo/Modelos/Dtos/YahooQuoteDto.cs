namespace MVFC.Connectors.Financas.Yahoo.Modelos.Dtos;

public sealed record YahooQuoteDto(
    [property: JsonPropertyName("high")] IReadOnlyList<double> High,
    [property: JsonPropertyName("low")] IReadOnlyList<double> Low,
    [property: JsonPropertyName("volume")] IReadOnlyList<long> Volume,
    [property: JsonPropertyName("open")] IReadOnlyList<double> Open,
    [property: JsonPropertyName("close")] IReadOnlyList<double> Close);
namespace MVFC.Connectors.Financas.Yahoo.Modelos.Dtos;

public sealed record YahooResultDto(
    [property: JsonPropertyName("meta")] YahooMetaDto Meta,
    [property: JsonPropertyName("timestamp")] IReadOnlyList<int> Timestamp,
    [property: JsonPropertyName("indicators")] YahooIndicatorsDto Indicators);
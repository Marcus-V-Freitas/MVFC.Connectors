namespace MVFC.Connectors.Financas.Yahoo.Modelos.Dtos;

public sealed record YahooTradingPeriodDto(
    [property: JsonPropertyName("pre")] YahooCurrentPeriodDto Pre,
    [property: JsonPropertyName("regular")] YahooCurrentPeriodDto Regular,
    [property: JsonPropertyName("post")] YahooCurrentPeriodDto Post);
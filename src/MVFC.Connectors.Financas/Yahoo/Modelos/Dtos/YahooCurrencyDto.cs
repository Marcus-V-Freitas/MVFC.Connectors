namespace MVFC.Connectors.Financas.Yahoo.Modelos.Dtos;

public sealed record YahooCurrencyDto(
    [property: JsonPropertyName("chart")] YahooChartDto Chart);

namespace MVFC.Connectors.Financas.Yahoo.Modelos.Dtos;

public sealed record YahooCurrency(
    [property: JsonPropertyName("chart")] YahooChartDto Chart);
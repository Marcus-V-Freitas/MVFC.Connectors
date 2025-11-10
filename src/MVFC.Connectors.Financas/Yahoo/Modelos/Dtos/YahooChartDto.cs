namespace MVFC.Connectors.Financas.Yahoo.Modelos.Dtos;

public sealed record YahooChartDto(
    [property: JsonPropertyName("result")] IReadOnlyList<YahooResultDto> Result,
    [property: JsonPropertyName("error")] object Error);

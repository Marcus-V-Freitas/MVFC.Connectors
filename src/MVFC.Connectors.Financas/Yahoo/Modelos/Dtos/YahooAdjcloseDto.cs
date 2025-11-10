namespace MVFC.Connectors.Financas.Yahoo.Modelos.Dtos;

public sealed record YahooAdjcloseDto(
    [property: JsonPropertyName("adjclose")] IReadOnlyList<double> Adjclose);
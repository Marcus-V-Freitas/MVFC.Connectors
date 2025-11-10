namespace MVFC.Connectors.Financas.Yahoo.Modelos.Dtos;

public sealed record YahooIndicatorsDto(
        [property: JsonPropertyName("quote")] IReadOnlyList<YahooQuoteDto> Quote,
        [property: JsonPropertyName("adjclose")] IReadOnlyList<YahooAdjcloseDto> Adjclose);
namespace MVFC.Connectors.Financas.Yahoo.Modelos.Dtos;

public sealed record YahooCurrentPeriodDto(
    [property: JsonPropertyName("timezone")] string Timezone,
    [property: JsonPropertyName("start")] int Start,
    [property: JsonPropertyName("end")] int End,
    [property: JsonPropertyName("gmtoffset")] int Gmtoffset);
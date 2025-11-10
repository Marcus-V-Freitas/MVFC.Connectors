namespace MVFC.Connectors.BrasilApi.Feriados.Modelos;

public sealed record FeriadoDto(
    [property: JsonPropertyName("date")] string Date,
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("type")] string Type);
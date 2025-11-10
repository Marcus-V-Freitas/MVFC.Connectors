namespace MVFC.Connectors.Geo.GeoNet.Modelos.Dtos;

public sealed record GeoNetAnswerDto(
        [property: JsonPropertyName("type")] string Type,
        [property: JsonPropertyName("value")] string Value);
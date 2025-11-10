namespace MVFC.Connectors.Geo.GeoNet.Modelos.Dtos;

public sealed record GeoNetDto(
        [property: JsonPropertyName("answers")] IReadOnlyList<GeoNetAnswerDto> Answers,
        [property: JsonPropertyName("from_loc")] GeoNetFromLoc FromLoc);
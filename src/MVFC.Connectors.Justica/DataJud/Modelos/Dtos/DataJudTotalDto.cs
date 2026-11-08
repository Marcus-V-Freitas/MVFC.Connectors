namespace MVFC.Connectors.Justica.DataJud.Modelos.Dtos;

public sealed record DataJudTotalDto(
    [property: JsonPropertyName("value")] int Value,
    [property: JsonPropertyName("relation")] string Relation);

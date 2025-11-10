namespace MVFC.Connectors.Justica.DataJud.Modelos;

public sealed record DataJudTotalDto(
    [property: JsonPropertyName("value")] int Value,
    [property: JsonPropertyName("relation")] string Relation);
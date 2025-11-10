namespace MVFC.Connectors.Justica.DataJud.Modelos;

public sealed record DataJudHitDto(
    [property: JsonPropertyName("_index")] string Index,
    [property: JsonPropertyName("_id")] string Id,
    [property: JsonPropertyName("_score")] double Score,
    [property: JsonPropertyName("_source")] DataJudProcessoDto Source,
    [property: JsonPropertyName("total")] DataJudTotalDto Total,
    [property: JsonPropertyName("max_score")] double MaxScore,
    [property: JsonPropertyName("hits")] IReadOnlyList<DataJudHitDto> Hits);
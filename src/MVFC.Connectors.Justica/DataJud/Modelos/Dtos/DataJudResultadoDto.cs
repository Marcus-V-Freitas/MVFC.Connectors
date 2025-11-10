namespace MVFC.Connectors.Justica.DataJud.Modelos;

public sealed record DataJudResultadoDto(
    [property: JsonPropertyName("took")] int Took,
    [property: JsonPropertyName("timed_out")] bool TimedOut,
    [property: JsonPropertyName("_shards")] DataJudShardsDto Shards,
    [property: JsonPropertyName("hits")] DataJudHitDto Hits);
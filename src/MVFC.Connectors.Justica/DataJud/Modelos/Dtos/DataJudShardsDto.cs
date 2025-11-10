namespace MVFC.Connectors.Justica.DataJud.Modelos;

public sealed record DataJudShardsDto(
    [property: JsonPropertyName("total")] int Total,
    [property: JsonPropertyName("successful")] int Successful,
    [property: JsonPropertyName("skipped")] int Skipped,
    [property: JsonPropertyName("failed")] int Failed);
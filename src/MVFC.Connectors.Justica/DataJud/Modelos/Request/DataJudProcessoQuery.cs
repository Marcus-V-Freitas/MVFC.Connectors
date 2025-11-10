namespace MVFC.Connectors.Justica.DataJud.Modelos.Request;

public sealed record DataJudProcessoQuery([property: JsonPropertyName("match")] DataJudProcessoMatch Match);
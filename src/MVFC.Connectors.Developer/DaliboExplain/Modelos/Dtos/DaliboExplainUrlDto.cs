namespace MVFC.Connectors.Developer.DaliboExplain.Modelos.Dtos;

public sealed record DaliboExplainUrlDto(
        [property: JsonPropertyName("deleteKey")] string DeleteKey,
        [property: JsonPropertyName("id")] string Id);

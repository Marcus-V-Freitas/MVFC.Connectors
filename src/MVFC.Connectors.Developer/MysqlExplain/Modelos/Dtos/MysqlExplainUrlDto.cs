namespace MVFC.Connectors.Developer.MysqlExplain.Modelos.Dtos;

public sealed record MysqlExplainUrlDto(
    [property: JsonPropertyName("url")] string Url);
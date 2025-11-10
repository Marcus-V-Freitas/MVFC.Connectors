namespace MVFC.Connectors.Developer.MysqlExplain.Modelos.Dtos;

public sealed record MysqlExplainIFrameDto(
    [property: JsonPropertyName("version")] string Version,
    [property: JsonPropertyName("type")] string Type,
    [property: JsonPropertyName("provider_name")] string ProviderName,
    [property: JsonPropertyName("provider_url")] string ProviderUrl,
    [property: JsonPropertyName("html")] string Html,
    [property: JsonPropertyName("url")] string Url,
    [property: JsonPropertyName("width")] string Width,
    [property: JsonPropertyName("height")] string Height);
namespace MVFC.Connectors.Developer.MysqlExplain.Modelos.Request;

public sealed record MysqlExplainRequestUrl(
    [property: JsonPropertyName("query")] string Query,
    [property: JsonPropertyName("bindings")] IReadOnlyList<string> Bindings,
    [property: JsonPropertyName("version")] string Version,
    [property: JsonPropertyName("explain_json")] string ExplainJson,
    [property: JsonPropertyName("explain_tree")] string ExplainTree);
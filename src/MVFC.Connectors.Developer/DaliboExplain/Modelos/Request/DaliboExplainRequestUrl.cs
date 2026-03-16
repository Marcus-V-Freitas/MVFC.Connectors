namespace MVFC.Connectors.Developer.DaliboExplain.Modelos.Request;

public sealed record DaliboExplainRequestUrl(
        [property: JsonPropertyName("title")] string Title,
        [property: JsonPropertyName("plan")] string Plan,
        [property: JsonPropertyName("query")] string Query,
        [property: JsonPropertyName("password")] string Password = "");

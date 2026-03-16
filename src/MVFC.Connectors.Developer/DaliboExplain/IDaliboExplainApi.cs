namespace MVFC.Connectors.Developer.DaliboExplain;

public interface IDaliboExplainApi : IConnectorApi
{
    [Post("/new.json")]
    public Task<ApiResponse<DaliboExplainUrlDto>> GerarVisualExplainUrlAsync([Body] DaliboExplainRequestUrl request);

    [Get("/plan/{id}")]
    public Task<ApiResponse<string>> ObterVisualExplainIAsync(string id);
}

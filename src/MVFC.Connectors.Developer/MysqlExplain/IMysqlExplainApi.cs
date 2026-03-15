namespace MVFC.Connectors.Developer.MysqlExplain;

public interface IMysqlExplainApi : IConnectorApi
{
    [Post("/explains")]
    public Task<ApiResponse<MysqlExplainUrlDto>> ObterVisualExplainUrlAsync([Body] MysqlExplainRequestUrl request);

    [Get("/oembed.json")]
    public Task<ApiResponse<MysqlExplainIFrameDto>> ObterVisualExplainIFrameAsync(string url);
}

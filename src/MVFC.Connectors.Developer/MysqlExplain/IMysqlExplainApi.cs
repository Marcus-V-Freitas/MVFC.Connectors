namespace MVFC.Connectors.Developer.MysqlExplain;

public interface IMysqlExplainApi : IConnectorApi
{
    [Post("/explains")]
    Task<ApiResponse<MysqlExplainUrlDto>> ObterVisualExplainUrlAsync([Body] MysqlExplainRequestUrl request);

    [Get("/oembed.json")]
    Task<ApiResponse<MysqlExplainIFrameDto>> ObterVisualExplainIFrameAsync(string url);
}
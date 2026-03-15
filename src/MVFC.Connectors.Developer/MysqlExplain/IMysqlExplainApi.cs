namespace MVFC.Connectors.Developer.MysqlExplain;

[Headers(
    "User-Agent: Mozilla/5.0 (compatible; MyApp/1.0)",
    "Accept: application/json",
    "Content-Type: application/json",
     "Connection: keep-alive",
    "Accept-Encoding: gzip, deflate, br",
    "Accept-Language: en-US,en;q=0.9"
)]
public interface IMysqlExplainApi : IConnectorApi
{
    [Post("/explains")]
    public Task<ApiResponse<MysqlExplainUrlDto>> ObterVisualExplainUrlAsync([Body] MysqlExplainRequestUrl request);

    [Get("/oembed.json")]
    public Task<ApiResponse<MysqlExplainIFrameDto>> ObterVisualExplainIFrameAsync(string url);
}

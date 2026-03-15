namespace MVFC.Connectors.Financas.Reddit;

public interface IRedditStockApi : IConnectorApi
{
    [Get("/apps/reddit")]
    public Task<ApiResponse<IReadOnlyList<RedditStockDto>>> ObterTopStocksAsync();
}

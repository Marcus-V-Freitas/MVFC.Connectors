namespace MVFC.Connectors.Financas.Reddit;

public interface IRedditStockApi : IConnectorApi
{
    [Get("/apps/reddit")]
    Task<ApiResponse<IReadOnlyList<RedditStockDto>>> ObterTopStocksAsync();
}
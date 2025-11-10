namespace MVFC.Connectors.Financas.Reddit.Extensoes;

public static class RedditExtensoes
{
    private const string URL_BASE = "https://api.tradestie.com/v1";

    public static IRedditStockApi ObterRedditStockApi() =>
         ExtensoesBase.ObterApi<IRedditStockApi>(URL_BASE).Construir();

    public static void AddRedditStock(this IServiceCollection services) =>
        services.AddApi<IRedditStockApi>(URL_BASE);
}
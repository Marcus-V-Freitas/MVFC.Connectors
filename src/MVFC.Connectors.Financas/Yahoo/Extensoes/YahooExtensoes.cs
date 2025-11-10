namespace MVFC.Connectors.Financas.Yahoo.Extensoes;

public static class YahooExtensoes
{
    private const string URL_BASE = "https://query1.finance.yahoo.com/v8";

    public static IYahooApi ObterYahooApi() =>
         ExtensoesBase.ObterApi<IYahooApi>(URL_BASE).Construir();

    public static void AddYahoo(this IServiceCollection services) =>
        services.AddApi<IYahooApi>(URL_BASE);
}
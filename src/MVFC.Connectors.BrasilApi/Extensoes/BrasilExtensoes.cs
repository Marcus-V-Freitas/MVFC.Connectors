namespace MVFC.Connectors.BrasilApi.Extensoes;

public static class BrasilExtensoes
{
    private const string URL_BASE = "https://brasilapi.com.br/api";

    public static T ObterBrasilApi<T>()
        where T : IConnectorApi =>
         ExtensoesBase.ObterApi<T>(URL_BASE).Construir();

    public static void AddBrasilApi<T>(this IServiceCollection services)
        where T : class, IConnectorApi =>
        services.AddApi<T>(URL_BASE);
}
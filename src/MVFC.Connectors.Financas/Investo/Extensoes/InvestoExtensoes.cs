namespace MVFC.Connectors.Financas.Investo.Extensoes;

public static class InvestoExtensoes
{
    private const string URL_BASE = "https://api.investoetf.com.br/api";

    public static IInvestoApi ObterInvestoApi() =>
         ExtensoesBase.ObterApi<IInvestoApi>(URL_BASE).Construir();

    public static void AddInvesto(this IServiceCollection services) =>
        services.AddApi<IInvestoApi>(URL_BASE);
}
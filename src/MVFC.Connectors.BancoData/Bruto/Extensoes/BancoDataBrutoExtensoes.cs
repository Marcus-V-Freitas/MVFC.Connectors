namespace MVFC.Connectors.BancoData.Bruto.Extensoes;

public static class BancoDataBrutoExtensoes
{
    private const string URL_BASE = "https://bancodata.com.br/relatorio";

    public static IBancoDataBrutoApi ObterBancoDataBrutoApi() =>
         ExtensoesBase.ObterApi<IBancoDataBrutoApi>(URL_BASE)
                      .AdicionarHandler(new BancoDataBrutoHandler(new BancoDataScraper()))
                      .Construir();

    public static void AddBancoDataBruto(this IServiceCollection services) =>
        services.AddApi<IBancoDataBrutoApi>(URL_BASE, (_, s) =>
        {
            s.AddSingleton<IBancoDataScraper, BancoDataScraper>();
            s.AddTransient<BancoDataBrutoHandler>();
        }).AddHttpMessageHandler<BancoDataBrutoHandler>();
}
namespace MVFC.Connectors.BancoData.Tratado.Extensoes;

public static class BancoDataTratadoExtensoes
{
    private const string URL_BASE = "https://bancodata.com.br/relatorio";

    public static IBancoDataTratadoApi ObterBancoTratadoApi() =>
         ExtensoesBase.ObterApi<IBancoDataTratadoApi>(URL_BASE)
                      .AdicionarHandler(new BancoDataTratadoHandler(new BancoDataScraper(), new BancoDataTransformer()))
                      .Construir();

    public static void AddBancoDataTratado(this IServiceCollection services) =>
        services.AddApi<IBancoDataTratadoApi>(URL_BASE, (_, s) =>
        {
            s.AddSingleton<IBancoDataScraper, BancoDataScraper>();
            s.AddSingleton<IBancoDataTransform, BancoDataTransformer>();
            s.AddTransient<BancoDataTratadoHandler>();
        }).AddHttpMessageHandler<BancoDataTratadoHandler>();
}
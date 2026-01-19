namespace MVFC.Connectors.Educacao.Hipolabs.Extensoes;

public static class HipolabsExtensoes
{
    private const string URL_BASE = "http://universities.hipolabs.com";

    public static IHipolabsApi ObterHipolabsApi() =>
         ExtensoesBase.ObterApi<IHipolabsApi>(URL_BASE).Construir();

    public static void AddHipolabs(this IServiceCollection services) =>
        services.AddApi<IHipolabsApi>(URL_BASE);
}
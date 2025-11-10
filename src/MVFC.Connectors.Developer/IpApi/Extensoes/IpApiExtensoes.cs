namespace MVFC.Connectors.Developer.IpApi.Extensoes;

public static class IpApiExtensoes
{
    private const string URL_BASE = "https://api.ipapi.is";

    public static IIpApi ObterIpApi() =>
         ExtensoesBase.ObterApi<IIpApi>(URL_BASE).Construir();

    public static void AddIp(this IServiceCollection services) =>
        services.AddApi<IIpApi>(URL_BASE);
}
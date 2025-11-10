namespace MVFC.Connectors.Geo.GeoNet.Extensoes;

public static class GeoNetApiExtensoes
{
    private const string URL_BASE = "https://geonet.shodan.io/api";

    public static IGeoNetApi ObterGeoNetApi() =>
         ExtensoesBase.ObterApi<IGeoNetApi>(URL_BASE).Construir();

    public static void AddGeoNet(this IServiceCollection services) =>
        services.AddApi<IGeoNetApi>(URL_BASE);
}
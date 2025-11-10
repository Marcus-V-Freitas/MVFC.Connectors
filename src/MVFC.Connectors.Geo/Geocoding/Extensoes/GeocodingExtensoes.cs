namespace MVFC.Connectors.Geo.Geocoding.Extensoes;

public static class GeocodingExtensoes
{
    private const string URL_BASE = "https://geocoding-api.open-meteo.com/v1";

    public static IGeocodingApi ObterGeocodingApi() =>
         ExtensoesBase.ObterApi<IGeocodingApi>(URL_BASE).Construir();

    public static void AddGeocoding(this IServiceCollection services) =>
        services.AddApi<IGeocodingApi>(URL_BASE);
}
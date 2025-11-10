namespace MVFC.Connectors.Geo.Geocoding;

public interface IGeocodingApi : IConnectorApi
{
    [Get("/search?name={nomeDaCidade}")]
    Task<ApiResponse<GeocodingDto>> ObterGeografiaPorNomeDaCidadeAsync(string nomeDaCidade);
}
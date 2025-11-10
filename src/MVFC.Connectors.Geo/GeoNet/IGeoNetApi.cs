namespace MVFC.Connectors.Geo.GeoNet;

public interface IGeoNetApi : IConnectorApi
{
    [Get("/geodns/{dominio}")]
    [QueryUriFormat(UriFormat.Unescaped)]
    Task<ApiResponse<IReadOnlyList<GeoNetDto>>> ObterDnsGeosPorDominioAsync(string dominio);
}
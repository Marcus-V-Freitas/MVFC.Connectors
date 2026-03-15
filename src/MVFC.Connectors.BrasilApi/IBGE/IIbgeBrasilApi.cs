namespace MVFC.Connectors.BrasilApi.IBGE;

public interface IIbgeBrasilApi : IConnectorApi
{
    [Get("/ibge/municipios/v1/{sigla}")]
    public Task<ApiResponse<IReadOnlyList<IbgeMunicipioDto>>> ObterMunicipiosPorUfAsync(IbgeSiglaUf sigla, [Query(CollectionFormat.Csv)] IReadOnlyList<IbgeProvedor>? providers = null);

    [Get("/ibge/uf/v1")]
    public Task<ApiResponse<IReadOnlyList<IbgeEstadoDto>>> ObterEstadosAsync();

    [Get("/ibge/uf/v1/{codigo}")]
    public Task<ApiResponse<IbgeEstadoDto>> ObterEstadoPorCodigoAsync(int codigo);
}

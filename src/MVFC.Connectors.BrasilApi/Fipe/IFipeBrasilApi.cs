namespace MVFC.Connectors.BrasilApi.Fipe;

public interface IFipeBrasilApi : IConnectorApi
{
    [Get("/fipe/marcas/v1/{tipoVeiculo}")]
    public Task<ApiResponse<IReadOnlyList<FipeMarcaDto>>> ObterMarcasPorTipoVeiculoAsync(FipeTipoVeiculo? tipoVeiculo = null);

    [Get("/fipe/preco/v1/{codigoFipe}")]
    public Task<ApiResponse<IReadOnlyList<FipeVeiculoDto>>> ObterVeiculosPorCodigoAsync(string codigoFipe);

    [Get("/fipe/tabelas/v1")]
    public Task<ApiResponse<IReadOnlyList<FipeTabelaDto>>> ObterTabelasFipeAsync();
}

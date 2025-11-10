namespace MVFC.Connectors.BrasilApi.Fipe;

public interface IFipeBrasilApi : IConnectorApi
{
    [Get("/fipe/marcas/v1/{tipoVeiculo}")]
    Task<ApiResponse<IReadOnlyList<FipeMarcaDto>>> ObterMarcasPorTipoVeiculoAsync(FipeTipoVeiculo? tipoVeiculo = null);

    [Get("/fipe/preco/v1/{codigoFipe}")]
    Task<ApiResponse<IReadOnlyList<FipeVeiculoDto>>> ObterVeiculosPorCodigoAsync(string codigoFipe);

    [Get("/fipe/tabelas/v1")]
    Task<ApiResponse<IReadOnlyList<FipeTabelaDto>>> ObterTabelasFipeAsync();
}
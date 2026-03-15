namespace MVFC.Connectors.BrasilApi.Bancos;

public interface IBancoBrasilApi : IConnectorApi
{
    [Get("/banks/v1")]
    public Task<ApiResponse<IReadOnlyList<BrasilBancoDto>>> ObterBancosAsync();

    [Get("/banks/v1/{codigo}")]
    public Task<ApiResponse<BrasilBancoDto>> ObterBancosPorCodigoAsync(int codigo);
}

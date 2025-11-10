namespace MVFC.Connectors.BrasilApi.Bancos;

public interface IBancoBrasilApi : IConnectorApi
{
    [Get("/banks/v1")]
    Task<ApiResponse<IReadOnlyList<BrasilBancoDto>>> ObterBancosAsync();

    [Get("/banks/v1/{codigo}")]
    Task<ApiResponse<BrasilBancoDto>> ObterBancosPorCodigoAsync(int codigo);
}
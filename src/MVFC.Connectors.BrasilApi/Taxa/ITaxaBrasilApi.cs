namespace MVFC.Connectors.BrasilApi.Taxa;

public interface ITaxaBrasilApi : IConnectorApi
{
    [Get("/taxas/v1/{sigla}")]
    Task<ApiResponse<TaxaDto>> GetTaxaAsync(string sigla);

    [Get("/taxas/v1")]
    Task<ApiResponse<IReadOnlyList<TaxaDto>>> GetTaxasAsync();
}
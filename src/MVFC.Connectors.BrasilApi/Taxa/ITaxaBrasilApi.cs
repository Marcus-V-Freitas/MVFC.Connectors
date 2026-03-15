namespace MVFC.Connectors.BrasilApi.Taxa;

public interface ITaxaBrasilApi : IConnectorApi
{
    [Get("/taxas/v1/{sigla}")]
    public Task<ApiResponse<TaxaDto>> ObterTaxaPorSiglaAsync(string sigla);

    [Get("/taxas/v1")]
    public Task<ApiResponse<IReadOnlyList<TaxaDto>>> ObterTaxasAsync();
}

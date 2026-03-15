namespace MVFC.Connectors.BrasilApi.NCM;

public interface INcmBrasilApi : IConnectorApi
{
    [Get("/ncm/v1")]
    public Task<ApiResponse<IReadOnlyList<NcmDto>>> ObterNcmsAsync();

    [Get("/ncm/v1?search={codigo}")]
    public Task<ApiResponse<IReadOnlyList<NcmDto>>> ObterNcmsPorCodigoAsync(string codigo);

    [Get("/ncm/v1/{codigo}")]
    public Task<ApiResponse<NcmDto>> ObterNcmPorCodigoAsync(string codigo);
}

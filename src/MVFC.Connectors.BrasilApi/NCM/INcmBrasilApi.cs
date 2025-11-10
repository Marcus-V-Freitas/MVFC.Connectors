namespace MVFC.Connectors.BrasilApi.NCM;

public interface INcmBrasilApi : IConnectorApi
{
    [Get("/ncm/v1")]
    Task<ApiResponse<IReadOnlyList<NcmDto>>> ObterNcmsAsync();

    [Get("/ncm/v1?search={codigo}")]
    Task<ApiResponse<IReadOnlyList<NcmDto>>> ObterNcmsPorCodigoAsync(string codigo);

    [Get("/ncm/v1/{codigo}")]
    Task<ApiResponse<NcmDto>> ObterNcmPorCodigoAsync(string codigo);
}
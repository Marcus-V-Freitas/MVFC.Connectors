namespace MVFC.Connectors.BrasilApi.NCM;

public interface INcmBrasilApi : IConnectorApi
{
    [Get("/ncm/v1")]
    Task<ApiResponse<IReadOnlyList<NcmDto>>> GetNcmsAsync();

    [Get("/ncm/v1?search={code}")]
    Task<ApiResponse<IReadOnlyList<NcmDto>>> GetNcmsBySearchCodeAsync(string code);

    [Get("/ncm/v1/{code}")]
    Task<ApiResponse<NcmDto>> GetNcmByCodeAsync(string code);
}
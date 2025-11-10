namespace MVFC.Connectors.BrasilApi.CPTEC;

public interface ICptecBrasilApi : IConnectorApi
{
    [Get("/cptec/v1/cidade")]
    Task<ApiResponse<IReadOnlyList<CptecCidadeDto>>> GetCidadesAsync();

    [Get("/cptec/v1/cidade/{cityName}")]
    Task<ApiResponse<IReadOnlyList<CptecCidadeDto>>> GetCidadesByNameAsync(string cityName);

    [Get("/cptec/v1/clima/aeroporto/{icaoCode}")]
    Task<ApiResponse<CptecClimaDto>> GetClimaByIcaoCodeAsync(string icaoCode);

    [Get("/cptec/v1/clima/previsao/{cityCode}")]
    Task<ApiResponse<CptecPrevisaoDto<CptecClimaCidadeDto>>> GetPrevisaoByCityCodeAsync(int cityCode);

    [Get("/cptec/v1/clima/previsao/{cityCode}/{days}")]
    Task<ApiResponse<CptecPrevisaoDto<CptecClimaCidadeDto>>> GetPrevisaoByCityCodeAndDaysAsync(int cityCode, int days);

    [Get("/cptec/v1/ondas/{cityCode}")]
    Task<ApiResponse<CptecPrevisaoDto<CptecOndaCidadeDto>>> GetOndasByCityCodeAsync(int cityCode);

    [Get("/cptec/v1/ondas/{cityCode}/{days}")]
    Task<ApiResponse<CptecPrevisaoDto<CptecOndaCidadeDto>>> GetOndasByCityCodeAndDaysAsync(int cityCode, int days);
}
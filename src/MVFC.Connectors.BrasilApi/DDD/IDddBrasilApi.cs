namespace MVFC.Connectors.BrasilApi.DDD;

public interface IDddBrasilApi : IConnectorApi
{
    [Get("/ddd/v1/{ddd}")]
    Task<ApiResponse<DddInfoDto>> GetDddInfoAsync(string ddd);
}
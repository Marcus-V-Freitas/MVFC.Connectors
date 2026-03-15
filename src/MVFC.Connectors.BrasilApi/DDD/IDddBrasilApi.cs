namespace MVFC.Connectors.BrasilApi.DDD;

public interface IDddBrasilApi : IConnectorApi
{
    [Get("/ddd/v1/{codigoDdd}")]
    public Task<ApiResponse<DddInfoDto>> ObterDddInfoPorCodigoAsync(string codigoDdd);
}

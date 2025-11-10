namespace MVFC.Connectors.Developer.IpApi;

public interface IIpApi : IConnectorApi
{
    [Get("/?q={numero}")]
    Task<ApiResponse<IpDto>> ObterIpPorNumeroAsync(string numero);
}
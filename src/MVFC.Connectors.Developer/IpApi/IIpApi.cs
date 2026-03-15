namespace MVFC.Connectors.Developer.IpApi;

public interface IIpApi : IConnectorApi
{
    [Get("/?q={numero}")]
    public Task<ApiResponse<IpDto>> ObterIpPorNumeroAsync(string numero);
}

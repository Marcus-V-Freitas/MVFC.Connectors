namespace MVFC.Connectors.Developer.KeyVal;

public interface IKeyValApi : IConnectorApi
{
    [Get("/set/{chave}/{valor}")]
    public Task<ApiResponse<KeyValDto>> AdicionarChaveAsync(string chave, string valor);

    [Get("/get/{chave}")]
    public Task<ApiResponse<KeyValDto>> ObterChaveAsync(string chave);
}

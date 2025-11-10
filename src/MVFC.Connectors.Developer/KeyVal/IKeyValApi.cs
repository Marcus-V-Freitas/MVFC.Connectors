namespace MVFC.Connectors.Developer.KeyVal;

public interface IKeyValApi : IConnectorApi
{
    [Get("/set/{chave}/{valor}")]
    Task<ApiResponse<KeyValDto>> AdicionarChaveAsync(string chave, string valor);

    [Get("/get/{chave}")]
    Task<ApiResponse<KeyValDto>> ObterChaveAsync(string chave);
}
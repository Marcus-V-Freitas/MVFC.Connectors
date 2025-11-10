namespace MVFC.Connectors.BrasilApi.CNPJ;

public interface ICnpjBrasilApi : IConnectorApi
{
    [Get("/cnpj/v1/{cnpj}")]
    Task<ApiResponse<CnpjDto>> GetCNPJAsync(string cnpj);
}
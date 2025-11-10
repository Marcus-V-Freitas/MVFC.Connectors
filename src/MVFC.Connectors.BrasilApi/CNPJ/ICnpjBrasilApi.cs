namespace MVFC.Connectors.BrasilApi.CNPJ;

public interface ICnpjBrasilApi : IConnectorApi
{
    [Get("/cnpj/v1/{cnpj}")]
    Task<ApiResponse<EmpresaCnpjDto>> ObterEmpresaPorCnpjAsync(string cnpj);
}
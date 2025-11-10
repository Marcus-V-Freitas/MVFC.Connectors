namespace MVFC.Connectors.BrasilApi.CEP;

public interface ICepBrasilApi : IConnectorApi
{
    [Get("/cep/{version}/{cep}")]
    Task<ApiResponse<CepDto>> GetCepAsync(string cep, string version = "v1");
}
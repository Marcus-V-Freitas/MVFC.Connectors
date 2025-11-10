namespace MVFC.Connectors.BrasilApi.CEP;

public interface ICepBrasilApi : IConnectorApi
{
    [Get("/cep/{version}/{cep}")]
    Task<ApiResponse<CepDto>> ObterCepPorNumeroAsync(string cep, string version = "v1");
}
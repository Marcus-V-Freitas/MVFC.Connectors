namespace MVFC.Connectors.BrasilApi.Corretoras;

public interface ICorretoraBrasilApi : IConnectorApi
{
    [Get("/cvm/corretoras/v1")]
    Task<ApiResponse<IReadOnlyList<CorretoraDto>>> GetCorretorasAsync();

    [Get("/cvm/corretoras/v1/{cnpj}")]
    Task<ApiResponse<CorretoraDto>> GetCorretoraByCnpjAsync(string cnpj);
}
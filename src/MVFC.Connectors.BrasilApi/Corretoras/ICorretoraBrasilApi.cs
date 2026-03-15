namespace MVFC.Connectors.BrasilApi.Corretoras;

public interface ICorretoraBrasilApi : IConnectorApi
{
    [Get("/cvm/corretoras/v1")]
    public Task<ApiResponse<IReadOnlyList<CorretoraDto>>> ObterCorretorasAsync();

    [Get("/cvm/corretoras/v1/{cnpj}")]
    public Task<ApiResponse<CorretoraDto>> ObterCorretoraPorCnpjAsync(string cnpj);
}

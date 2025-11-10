namespace MVFC.Connectors.BrasilApi.Banks;

public interface IBankBrasilApi : IConnectorApi
{
    [Get("/banks/v1")]
    Task<ApiResponse<IReadOnlyList<BankDto>>> GetBanksAsync();

    [Get("/banks/v1/{code}")]
    Task<ApiResponse<BankDto>> GetBankByCodeAsync(int code);
}
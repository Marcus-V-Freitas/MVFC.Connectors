namespace MVFC.Connectors.Financas.Yahoo;

public interface IYahooApi : IConnectorApi
{
    [Get("/finance/chart/{nome}")]
    public Task<ApiResponse<YahooCurrency>> ObterMoedaPorNomeEPeriodoAsync(string nome, [Query] string interval = "1d");
}

namespace MVFC.Connectors.Financas.Investo;

public interface IInvestoApi : IConnectorApi
{
    [Get("/produtos/{nome}")]
    public Task<ApiResponse<InvestoEtfDto>> ObterEtfPorNomeAsync(string nome);
}
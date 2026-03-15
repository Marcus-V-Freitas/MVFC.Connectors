namespace MVFC.Connectors.Sicoob.CobrancaBancaria;

public partial interface ISicoobCobrancaBancariaApi
{
    [Post("/boletos/{nossoNumero}/negativacoes")]
    public Task<ApiResponse<string>> NegativarBoletoAsync(int nossoNumero, [Body] NegativacaoRequest request);

    [Patch("/boletos/{nossoNumero}/negativacoes")]
    public Task<ApiResponse<string>> CancelarNegativacaoAsync(int nossoNumero, [Body] NegativacaoRequest request);

    [Delete("/boletos/{nossoNumero}/negativacoes")]
    public Task<ApiResponse<string>> BaixarNegativacaoAsync(int nossoNumero, [Body] NegativacaoRequest request);
}

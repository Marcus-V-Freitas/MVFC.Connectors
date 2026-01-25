namespace MVFC.Connectors.Sicoob.CobrancaBancaria;

public partial interface ISicoobCobrancaBancariaApi
{
    [Post("/boletos/{nossoNumero}/negativacoes")]
    Task<ApiResponse<string>> NegativarBoletoAsync(int nossoNumero, [Body] NegativacaoRequest boleto);

    [Patch("/boletos/{nossoNumero}/negativacoes")]
    Task<ApiResponse<string>> CancelarNegativacaoAsync(int nossoNumero, [Body] NegativacaoRequest boleto);

    [Delete("/boletos/{nossoNumero}/negativacoes")]
    Task<ApiResponse<string>> BaixarNegativacaoAsync(int nossoNumero, [Body] NegativacaoRequest boleto);
}
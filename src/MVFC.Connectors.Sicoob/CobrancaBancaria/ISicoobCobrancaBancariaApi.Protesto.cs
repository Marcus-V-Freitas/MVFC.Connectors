namespace MVFC.Connectors.Sicoob.CobrancaBancaria;

public partial interface ISicoobCobrancaBancariaApi
{
    [Post("/boletos/{nossoNumero}/protestos")]
    Task<ApiResponse<string>> ProtestarBoletoAsync(int nossoNumero, [Body] ProtestoRequest boleto);

    [Patch("/boletos/{nossoNumero}/protestos")]
    Task<ApiResponse<string>> CancelarProtestoAsync(int nossoNumero, [Body] ProtestoRequest boleto);

    [Delete("/boletos/{nossoNumero}/protestos")]
    Task<ApiResponse<string>> DesistirProtestoAsync(int nossoNumero, [Body] ProtestoRequest boleto);
}
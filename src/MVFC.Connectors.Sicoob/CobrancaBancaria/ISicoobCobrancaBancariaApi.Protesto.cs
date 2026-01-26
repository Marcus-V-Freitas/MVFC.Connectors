namespace MVFC.Connectors.Sicoob.CobrancaBancaria;

public partial interface ISicoobCobrancaBancariaApi
{
    [Post("/boletos/{nossoNumero}/protestos")]
    Task<ApiResponse<string>> ProtestarBoletoAsync(int nossoNumero, [Body] ProtestoRequest request);

    [Patch("/boletos/{nossoNumero}/protestos")]
    Task<ApiResponse<string>> CancelarProtestoAsync(int nossoNumero, [Body] ProtestoRequest request);

    [Delete("/boletos/{nossoNumero}/protestos")]
    Task<ApiResponse<string>> DesistirProtestoAsync(int nossoNumero, [Body] ProtestoRequest request);
}
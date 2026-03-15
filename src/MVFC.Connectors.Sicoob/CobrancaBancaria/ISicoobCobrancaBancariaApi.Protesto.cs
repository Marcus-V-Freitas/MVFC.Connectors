namespace MVFC.Connectors.Sicoob.CobrancaBancaria;

public partial interface ISicoobCobrancaBancariaApi
{
    [Post("/boletos/{nossoNumero}/protestos")]
    public Task<ApiResponse<string>> ProtestarBoletoAsync(int nossoNumero, [Body] ProtestoRequest request);

    [Patch("/boletos/{nossoNumero}/protestos")]
    public Task<ApiResponse<string>> CancelarProtestoAsync(int nossoNumero, [Body] ProtestoRequest request);

    [Delete("/boletos/{nossoNumero}/protestos")]
    public Task<ApiResponse<string>> DesistirProtestoAsync(int nossoNumero, [Body] ProtestoRequest request);
}

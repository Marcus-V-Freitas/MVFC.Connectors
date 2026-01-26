namespace MVFC.Connectors.Sicoob.CobrancaBancaria;

public partial interface ISicoobCobrancaBancariaApi
{
    [Put("/pagadores")]
    Task<ApiResponse<string>> AlterarPagadorAsync([Body] PagadorRequest request);
}
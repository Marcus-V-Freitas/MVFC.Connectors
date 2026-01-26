namespace MVFC.Connectors.Sicoob.CobrancaBancariaPagamento;

public partial interface ISicoobCobrancaBancariaPagamentoApi
{
    [Get("/boletos")]
    Task<ApiResponse<BoletoDdaResponse[]>> ConsultarBoletosDdaAsync([Query] ConsultarBoletosDdaQuery query);
}
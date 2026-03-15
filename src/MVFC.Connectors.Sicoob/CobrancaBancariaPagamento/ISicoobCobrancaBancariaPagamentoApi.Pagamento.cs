namespace MVFC.Connectors.Sicoob.CobrancaBancariaPagamento;

public partial interface ISicoobCobrancaBancariaPagamentoApi
{
    [Get("/boletos")]
    public Task<ApiResponse<BoletoDdaResponse[]>> ConsultarBoletosDdaAsync([Query] ConsultarBoletosDdaQuery query);
}

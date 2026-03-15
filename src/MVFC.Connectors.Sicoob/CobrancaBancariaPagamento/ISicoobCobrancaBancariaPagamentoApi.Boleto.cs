namespace MVFC.Connectors.Sicoob.CobrancaBancariaPagamento;

public partial interface ISicoobCobrancaBancariaPagamentoApi
{
    [Get("/boletos/{codigoBarras}")]
    public Task<ApiResponse<SicoobResponse<BoletoConsultaPagamentoResponse>>> ConsultarBoletoAsync(string codigoBarras, [Query] ConsultarBoletoQuery query);

    [Post("/boletos/pagamentos/{codigoBarras}")]
    public Task<ApiResponse<SicoobResponse<ComprovantePagamentoResponse>>> PagarBoletoAsync([Header("x-idempotency-key")] string idempotencyKey, string codigoBarras, [Body] BoletoPagamentoRequest request);

    [Get("/boletos/pagamentos/{idPagamento}/comprovantes")]
    public Task<ApiResponse<ComprovanteResponse>> ConsultarComprovanteAsync(long idPagamento, [Query] ConsultarComprovanteQuery query);

    [Delete("/boletos/pagamentos/agendamentos/{idPagamento}")]
    public Task<ApiResponse<string>> CancelarAgendamentoAsync(long idPagamento, [Body] CancelamentoRequest request);

    [Get("/boletos/pagamentos/{idempotency}/idempotency/comprovantes")]
    public Task<ApiResponse<ComprovantePagamentoResponse>> ConsultarComprovantePorIdempotencyAsync(string idempotency);
}

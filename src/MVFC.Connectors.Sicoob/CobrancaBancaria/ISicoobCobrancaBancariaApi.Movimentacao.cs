namespace MVFC.Connectors.Sicoob.CobrancaBancaria;

public partial interface ISicoobCobrancaBancariaApi
{
    [Post("/boletos/movimentacoes")]
    public Task<ApiResponse<SicoobResponse<MovimentacaoSolicitacaoResponse>>> SolicitarMovimentacaoAsync([Body] MovimentacaoRequest request);

    [Get("/boletos/movimentacoes")]
    public Task<ApiResponse<SicoobResponse<MovimentacaoQuantidadeResponse>>> ConsultarMovimentacaoAsync([Query] ConsultarMovimentacaoQuery query);

    [Get("/boletos/movimentacoes/download")]
    public Task<ApiResponse<SicoobResponse<MovimentacaoDownloadResponse>>> DownloadMovimentacaoAsync([Query] DownloadMovimentacaoQuery query);
}

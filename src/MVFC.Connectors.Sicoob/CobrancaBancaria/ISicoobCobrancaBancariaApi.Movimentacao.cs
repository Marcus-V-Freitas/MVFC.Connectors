namespace MVFC.Connectors.Sicoob.CobrancaBancaria;

public partial interface ISicoobCobrancaBancariaApi
{
    [Post("/boletos/movimentacoes")]
    Task<ApiResponse<SicoobResponse<MovimentacaoSolicitacaoResponse>>> SolicitarMovimentacaoAsync([Body] MovimentacaoRequest request);

    [Get("/boletos/movimentacoes")]
    Task<ApiResponse<SicoobResponse<MovimentacaoQuantidadeResponse>>> ConsultarMovimentacaoAsync([Query] ConsultarMovimentacaoQuery query);

    [Get("/boletos/movimentacoes/download")]
    Task<ApiResponse<SicoobResponse<MovimentacaoDownloadResponse>>> DownloadMovimentacaoAsync([Query] DownloadMovimentacaoQuery query);
}
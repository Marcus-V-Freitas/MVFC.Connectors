namespace MVFC.Connectors.Sicoob.CobrancaBancaria;

public partial interface ISicoobCobrancaBancariaApi
{
    [Post("/webhooks")]
    public Task<ApiResponse<SicoobResponse<WebhookCBCadastroResponse>>> CadastrarWebhookAsync([Body] WebhookCBCadastroRequest request);

    [Get("/webhooks")]
    public Task<ApiResponse<SicoobResponse<WebhookCBResponse[]>>> ConsultarWebhooksAsync([Query] CobrancaWebhookConsultarQuery query);

    [Patch("/webhooks/{idWebhook}")]
    public Task<ApiResponse<string>> AtualizarWebhookAsync(long idWebhook, [Body] WebhookCBAlteracaoRequest request);

    [Delete("/webhooks/{idWebhook}")]
    public Task<ApiResponse<string>> ExcluirWebhookAsync(long idWebhook);

    [Patch("/webhooks/{idWebhook}/reativar")]
    public Task<ApiResponse<string>> ReativarWebhookAsync(long idWebhook);

    [Get("/webhooks/{idWebhook}/solicitacoes")]
    public Task<ApiResponse<SicoobResponse<WebhookCBSolicitacoesResponse>>> ConsultarSolicitacoesWebhookAsync(long idWebhook, [Query] SolicitacaoWebhookConsultaQuery query);
}

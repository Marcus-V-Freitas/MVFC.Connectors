namespace MVFC.Connectors.Sicoob.CobrancaBancaria;

public partial interface ISicoobCobrancaBancariaApi
{
    [Post("/webhooks")]
    Task<ApiResponse<SicoobResponse<WebhookCBCadastroResponse>>> CadastrarWebhookAsync([Body] WebhookCBCadastroRequest webhook);

    [Get("/webhooks")]
    Task<ApiResponse<SicoobResponse<WebhookCBResponse[]>>> ConsultarWebhooksAsync([Query] CobrancaWebhookConsultarQuery query);

    [Patch("/webhooks/{idWebhook}")]
    Task<ApiResponse<string>> AtualizarWebhookAsync(long idWebhook, [Body] WebhookCBAlteracaoRequest webhook);

    [Delete("/webhooks/{idWebhook}")]
    Task<ApiResponse<string>> ExcluirWebhookAsync(long idWebhook);

    [Patch("/webhooks/{idWebhook}/reativar")]
    Task<ApiResponse<string>> ReativarWebhookAsync(long idWebhook);

    [Get("/webhooks/{idWebhook}/solicitacoes")]
    Task<ApiResponse<SicoobResponse<WebhookCBSolicitacoesResponse>>> ConsultarSolicitacoesWebhookAsync(long idWebhook, [Query] SolicitacaoWebhookConsultaQuery query);
}
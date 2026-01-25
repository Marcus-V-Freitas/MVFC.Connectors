namespace MVFC.Connectors.Sicoob.Modelos.Response.CobrancaBancaria;

public sealed record WebhookCBSolicitacoesResponse(
    [property: JsonPropertyName("paginaAtual")] int PaginaAtual,
    [property: JsonPropertyName("totalPaginas")] int TotalPaginas,
    [property: JsonPropertyName("totalRegistros")] int TotalRegistros,
    [property: JsonPropertyName("webhookSolicitacoes")] WebhookCBSolicitacaoItemResponse[] WebhookSolicitacoes);
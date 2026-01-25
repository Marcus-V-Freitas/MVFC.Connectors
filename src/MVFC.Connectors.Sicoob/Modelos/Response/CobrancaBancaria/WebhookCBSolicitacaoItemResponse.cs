namespace MVFC.Connectors.Sicoob.Modelos.Response.CobrancaBancaria;

public sealed record WebhookCBSolicitacaoItemResponse(
    [property: JsonPropertyName("codigoWebhookSituacao")] CodigoSituacao CodigoWebhookSituacao,
    [property: JsonPropertyName("descricaoWebhookSituacao")] string DescricaoWebhookSituacao,
    [property: JsonPropertyName("codigoSolicitacaoSituacao")] CodigoSolicitacaoSituacao CodigoSolicitacaoSituacao,
    [property: JsonPropertyName("descricaoSolicitacaoSituacao")] string DescricaoSolicitacaoSituacao,
    [property: JsonPropertyName("codigoTipoMovimento")] CodigoTipoMovimento CodigoTipoMovimento,
    [property: JsonPropertyName("descricaoTipoMovimento")] string DescricaoTipoMovimento,
    [property: JsonPropertyName("codigoPeriodoMovimento")] CodigoPeriodoMovimento CodigoPeriodoMovimento,
    [property: JsonPropertyName("descricaoPeriodoMovimento")] string DescricaoPeriodoMovimento,
    [property: JsonPropertyName("dataHoraCadastro")] DateTime DataHoraCadastro,
    [property: JsonPropertyName("validacaoWebhook")] bool ValidacaoWebhook)
{
    [JsonPropertyName("descricaoErroProcessamento")]
    public string? DescricaoErroProcessamento { get; init; }
}
namespace MVFC.Connectors.Sicoob.Modelos.Response.CobrancaBancaria;

public sealed record WebhookCBResponse(
    [property: JsonPropertyName("idWebhook")] long IdWebhook,
    [property: JsonPropertyName("url")] string Url,
    [property: JsonPropertyName("codigoTipoMovimento")] CodigoTipoMovimento CodigoTipoMovimento,
    [property: JsonPropertyName("descricaoTipoMovimento")] string DescricaoTipoMovimento,
    [property: JsonPropertyName("codigoPeriodoMovimento")] CodigoPeriodoMovimento CodigoPeriodoMovimento,
    [property: JsonPropertyName("descricaoPeriodoMovimento")] string DescricaoPeriodoMovimento,
    [property: JsonPropertyName("codigoSituacao")] CodigoSituacao CodigoSituacao,
    [property: JsonPropertyName("descricaoSituacao")] string DescricaoSituacao,
    [property: JsonPropertyName("dataHoraCadastro")] DateTime DataHoraCadastro,
    [property: JsonPropertyName("validacaoWebhook")] bool ValidacaoWebhook)
{
    [JsonPropertyName("email")]
    public string? Email { get; init; }

    [JsonPropertyName("dataHoraUltimaAlteracao")]
    public DateTime? DataHoraUltimaAlteracao { get; init; }

    [JsonPropertyName("dataHoraInativacao")]
    public DateTime? DataHoraInativacao { get; init; }

    [JsonPropertyName("descricaoMotivoInativacao")]
    public string? DescricaoMotivoInativacao { get; init; }
}
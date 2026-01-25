namespace MVFC.Connectors.Sicoob.Modelos.Request.CobrancaBancaria;

public sealed record WebhookCBCadastroRequest(
    [property: JsonPropertyName("url")] string Url,
    [property: JsonPropertyName("codigoTipoMovimento")] CodigoTipoMovimento CodigoTipoMovimento,
    [property: JsonPropertyName("codigoPeriodoMovimento")] CodigoPeriodoMovimento CodigoPeriodoMovimento)
{
    [JsonPropertyName("email")]
    public string? Email { get; init; }
}
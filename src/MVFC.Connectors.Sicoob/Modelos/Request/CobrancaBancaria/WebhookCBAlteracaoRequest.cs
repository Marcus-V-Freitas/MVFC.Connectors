namespace MVFC.Connectors.Sicoob.Modelos.Request.CobrancaBancaria;

public sealed record WebhookCBAlteracaoRequest(
    [property: JsonPropertyName("url")] string Url)
{
    [JsonPropertyName("email")]
    public string? Email { get; init; }
}
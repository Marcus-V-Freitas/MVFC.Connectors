namespace MVFC.Connectors.Sicoob.Modelos.Response.CobrancaBancaria;

public sealed record WebhookCBCadastroResponse(
    [property: JsonPropertyName("idWebhook")] long IdWebhook);
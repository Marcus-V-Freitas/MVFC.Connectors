namespace MVFC.Connectors.Sicoob.Modelos.Query.CobrancaBancaria;

public sealed record CobrancaWebhookConsultarQuery(
    [property: AliasAs("idWebhook")] long? IdWebhook = null,
    [property: JsonIgnore] CodigoTipoMovimento? CodigoTipoMovimento = null)
{
    [AliasAs("codigoTipoMovimento")]
    public int? CodigoTipoMovimentoValue => (int?)CodigoTipoMovimento;
}
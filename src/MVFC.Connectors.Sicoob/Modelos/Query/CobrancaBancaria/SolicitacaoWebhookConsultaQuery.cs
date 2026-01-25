namespace MVFC.Connectors.Sicoob.Modelos.Query.CobrancaBancaria;

public sealed record SolicitacaoWebhookConsultaQuery(
    [property: AliasAs("dataSolicitacao"), Query(Format = "yyyy-MM-dd")] DateOnly DataSolicitacao,
    [property: AliasAs("pagina")] int? Pagina = null,
    [property: JsonIgnore] CodigoSolicitacaoSituacao? CodigoSolicitacaoSituacao = null,
    [property: AliasAs("codigoBarras")] string? CodigoBarras = null,
    [property: AliasAs("nossoNumero")] long? NossoNumero = null)
{
    [AliasAs("codigoSolicitacaoSituacao")]
    public int? CodigoSolicitacaoSituacaoValue => (int?)CodigoSolicitacaoSituacao;
}
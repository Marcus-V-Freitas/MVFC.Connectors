namespace MVFC.Connectors.Sicoob.Modelos.Query.CobrancaBancaria;

public sealed record BoletoConsultarPagadorQuery(
    [property: AliasAs("numeroCliente")] int NumeroCliente,
    [property: AliasAs("codigoSituacao")] SituacaoBoleto? CodigoSituacao = null,
    [property: AliasAs("dataInicio"), Query(Format = "yyyy-MM-dd")] DateOnly? DataInicio = null,
    [property: AliasAs("dataFim"), Query(Format = "yyyy-MM-dd")] DateOnly? DataFim = null)
{
    [AliasAs("codigoSituacao")]
    public int? CodigoSituacaoValue => (int?)CodigoSituacao;
}
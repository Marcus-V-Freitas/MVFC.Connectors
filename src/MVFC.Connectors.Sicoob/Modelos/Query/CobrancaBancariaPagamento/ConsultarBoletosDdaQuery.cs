namespace MVFC.Connectors.Sicoob.Modelos.Query.CobrancaBancariaPagamento;

public sealed record ConsultarBoletosDdaQuery(
    [property: AliasAs("numeroConta")] long NumeroConta,
    [property: AliasAs("dataInicial"), Query(Format = "yyyy-MM-dd")] DateOnly DataInicial,
    [property: AliasAs("dataFinal"), Query(Format = "yyyy-MM-dd")] DateOnly DataFinal,
    [property: AliasAs(null!)] TipoData TipoData,
    [property: AliasAs(null!)] SituacaoBoletoPagamento? Situacao = null)
{
    [AliasAs("tipoData")]
    public int TipoDataValue => (int)TipoData;

    [AliasAs("situacao")]
    public int? SituacaoValue => (int?)Situacao;
}
namespace MVFC.Connectors.Sicoob.Modelos.Query.CobrancaBancariaPagamento;

public sealed record ConsultarBoletoQuery(
    [property: AliasAs("numeroConta")] long NumeroConta,
    [property: AliasAs("dataPagamento"), Query(Format = "yyyy-MM-dd")] DateOnly? DataPagamento = null);
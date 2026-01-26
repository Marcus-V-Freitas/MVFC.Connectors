namespace MVFC.Connectors.Sicoob.Modelos.Query.CobrancaBancariaPagamento;

public sealed record ConsultarComprovanteQuery(
    [property: AliasAs("numeroConta")] long NumeroConta);
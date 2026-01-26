namespace MVFC.Connectors.Sicoob.Modelos.Request.CobrancaBancariaPagamento;

public sealed record CancelamentoRequest(
    [property: JsonPropertyName("numeroConta")] long NumeroConta);
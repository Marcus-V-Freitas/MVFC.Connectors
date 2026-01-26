namespace MVFC.Connectors.Sicoob.Modelos.Request.CobrancaBancariaPagamento;

public sealed record BoletoPagamentoRequest(
    [property: JsonPropertyName("identificadorConsulta")] string IdentificadorConsulta,
    [property: JsonPropertyName("valorBoleto")] decimal ValorBoleto,
    [property: JsonPropertyName("valorDescontoAbatimento")] decimal ValorDescontoAbatimento,
    [property: JsonPropertyName("valorMultaMora")] decimal ValorMultaMora,
    [property: JsonPropertyName("aceitaValorDivergente")] bool AceitaValorDivergente,
    [property: JsonPropertyName("numeroCpfCnpjPortador")] string NumeroCpfCnpjPortador,
    [property: JsonPropertyName("nomePortador")] string NomePortador,
    [property: JsonPropertyName("date")] DateOnly Date,
    [property: JsonPropertyName("amount")] decimal Amount,
    [property: JsonPropertyName("debtorAccount")] DebtorAccountDto DebtorAccount)
{
    [JsonPropertyName("descricaoObservacao")]
    public string? DescricaoObservacao { get; init; }
}
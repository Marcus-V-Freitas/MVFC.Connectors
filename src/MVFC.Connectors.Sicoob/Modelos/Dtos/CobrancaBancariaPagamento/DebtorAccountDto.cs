namespace MVFC.Connectors.Sicoob.Modelos.Dtos.CobrancaBancariaPagamento;

public sealed record DebtorAccountDto(
    [property: JsonPropertyName("issuer")] int Issuer,
    [property: JsonPropertyName("number")] long Number,
    [property: JsonPropertyName("personType")] TipoPessoa PersonType,
    [property: JsonPropertyName("accountType")] TipoConta AccountType = TipoConta.ContaCorrente);
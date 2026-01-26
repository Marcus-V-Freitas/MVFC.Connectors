namespace MVFC.Connectors.Sicoob.Enums.CobrancaBancariaPagamento;

[JsonConverter(typeof(SafeEnumConverter<TipoPessoa>))]
public enum TipoPessoa
{
    [JsonStringEnumMemberName("Pessoa Física")]
    PessoaFisica = 0,
    [JsonStringEnumMemberName("Pessoa Jurídica")]
    PessoaJuridica = 1,
}
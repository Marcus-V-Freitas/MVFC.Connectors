namespace MVFC.Connectors.Sicoob.Enums.CobrancaBancariaPagamento;

[JsonConverter(typeof(SafeEnumConverter<TipoPessoaStr>))]
public enum TipoPessoaStr
{
    [JsonStringEnumMemberName("Desconhecido")]
    Desconhecido,
    [JsonStringEnumMemberName("F")]
    F,
    [JsonStringEnumMemberName("J")]
    J,
}
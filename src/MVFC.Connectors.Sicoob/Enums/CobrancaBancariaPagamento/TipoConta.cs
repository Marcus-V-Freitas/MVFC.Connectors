namespace MVFC.Connectors.Sicoob.Enums.CobrancaBancariaPagamento;

[JsonConverter(typeof(SafeEnumConverter<TipoConta>))]
public enum TipoConta
{
    [JsonStringEnumMemberName("Conta Corrente")]
    ContaCorrente = 0,
}
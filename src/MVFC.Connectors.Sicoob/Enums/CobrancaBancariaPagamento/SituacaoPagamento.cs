namespace MVFC.Connectors.Sicoob.Enums.CobrancaBancariaPagamento;

[JsonConverter(typeof(SafeEnumConverter<SituacaoPagamento>))]
public enum SituacaoPagamento
{
    [JsonStringEnumMemberName("Desconhecido")]
    Desconhecido,
    [JsonStringEnumMemberName("Rejeitado")]
    Rejeitado,
    [JsonStringEnumMemberName("Agendado")]
    Agendado,
    [JsonStringEnumMemberName("Efetivado")]
    Efetivado,
    [JsonStringEnumMemberName("Cancelado")]
    Cancelado,
}
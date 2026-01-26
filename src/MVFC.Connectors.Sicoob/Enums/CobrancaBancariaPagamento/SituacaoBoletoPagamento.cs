namespace MVFC.Connectors.Sicoob.Enums.CobrancaBancariaPagamento;

[JsonConverter(typeof(SafeEnumConverter<SituacaoBoletoPagamento>))]
public enum SituacaoBoletoPagamento
{
    [JsonStringEnumMemberName("Desconhecido")]
    Desconhecido = 0,
    [JsonStringEnumMemberName("Em aberto")]
    EmAberto = 1,
    [JsonStringEnumMemberName("Agendado")]
    Agendado = 2,
    [JsonStringEnumMemberName("Liquidado")]
    Liquidado = 3,
    [JsonStringEnumMemberName("Baixado")]
    Baixado = 4,
}
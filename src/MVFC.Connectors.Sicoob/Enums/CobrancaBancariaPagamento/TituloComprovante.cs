namespace MVFC.Connectors.Sicoob.Enums.CobrancaBancariaPagamento;

[JsonConverter(typeof(SafeEnumConverter<TituloComprovante>))]
public enum TituloComprovante
{
    [JsonStringEnumMemberName("Desconhecido")]
    Desconhecido,
    [JsonStringEnumMemberName("AGENDAMENTO DE BOLETO")]
    AgendamentoBoleto,
    [JsonStringEnumMemberName("PAGAMENTO DE BOLETO")]
    PagamentoBoleto,
    [JsonStringEnumMemberName("PAGAMENTO REJEITADO")]
    PagamentoRejeitado,
    [JsonStringEnumMemberName("PAGAMENTO CANCELADO")]
    PagamentoCancelado,
    [JsonStringEnumMemberName("AGENDAMENTO DE BOLETO VLB")]
    AgendamentoBoletoVlb,
    [JsonStringEnumMemberName("PAGAMENTO DE BOLETO VLB")]
    PagamentoBoletoVlb,
    [JsonStringEnumMemberName("PAGAMENTO VLB REJEITADO")]
    PagamentoVlbRejeitado,
    [JsonStringEnumMemberName("PAGAMENTO VLB CANCELADO")]
    PagamentoVlbCancelado,
}
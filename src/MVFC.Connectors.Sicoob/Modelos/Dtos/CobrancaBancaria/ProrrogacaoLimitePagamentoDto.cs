namespace MVFC.Connectors.Sicoob.Modelos.Dtos.CobrancaBancaria;

public sealed record ProrrogacaoLimitePagamentoDto(
    [property: JsonPropertyName("dataLimitePagamento")] DateOnly DataLimitePagamento);
namespace MVFC.Connectors.Sicoob.Modelos.Dtos.CobrancaBancaria;

public sealed record ProrrogacaoVencimentoDto(
    [property: JsonPropertyName("dataVencimento")] DateOnly DataVencimento);

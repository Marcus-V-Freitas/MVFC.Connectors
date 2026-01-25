namespace MVFC.Connectors.Sicoob.Modelos.Dtos.CobrancaBancaria;

public sealed record ProrrogacaoVencimento(
    [property: JsonPropertyName("dataVencimento")] DateOnly DataVencimento);
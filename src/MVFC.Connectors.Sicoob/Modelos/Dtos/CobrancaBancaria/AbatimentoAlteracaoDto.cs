namespace MVFC.Connectors.Sicoob.Modelos.Dtos.CobrancaBancaria;

public sealed record AbatimentoAlteracaoDto(
    [property: JsonPropertyName("valorAbatimento")] decimal ValorAbatimento);
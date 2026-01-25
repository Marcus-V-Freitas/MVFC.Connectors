namespace MVFC.Connectors.Sicoob.Modelos.Dtos.CobrancaBancaria;

public sealed record ValorNominalAlteracaoDto(
    [property: JsonPropertyName("valor")] decimal Valor);
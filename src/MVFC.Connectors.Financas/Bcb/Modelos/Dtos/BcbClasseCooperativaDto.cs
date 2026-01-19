namespace MVFC.Connectors.Financas.Bcb.Modelos.Dtos;

public sealed record BcbClasseCooperativaDto(
        [property: JsonPropertyName("id")] int Id,
        [property: JsonPropertyName("nome")] string Nome);
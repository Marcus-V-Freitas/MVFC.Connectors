namespace MVFC.Connectors.Financas.Bcb.Modelos.Dtos;

public sealed record BcbMunicipioDto(
        [property: JsonPropertyName("nome")] string Nome,
        [property: JsonPropertyName("siglaEstado")] string SiglaEstado,
        [property: JsonPropertyName("pais")] string Pais);
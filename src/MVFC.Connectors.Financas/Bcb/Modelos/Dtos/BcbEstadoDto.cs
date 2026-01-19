namespace MVFC.Connectors.Financas.Bcb.Modelos.Dtos;

public sealed record BcbEstadoDto(
        [property: JsonPropertyName("nome")] string Nome,
        [property: JsonPropertyName("sigla")] string Sigla);
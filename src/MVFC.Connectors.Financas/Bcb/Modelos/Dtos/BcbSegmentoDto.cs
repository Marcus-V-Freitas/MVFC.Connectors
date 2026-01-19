namespace MVFC.Connectors.Financas.Bcb.Modelos.Dtos;

public sealed record BcbSegmentoDto(
        [property: JsonPropertyName("id")] int Id,
        [property: JsonPropertyName("nome")] string Nome,
        [property: JsonPropertyName("ativo")] bool Ativo = true);
namespace MVFC.Connectors.Financas.Bcb.Modelos.Dtos;

public sealed record BcbAuditoriaDto(
        [property: JsonPropertyName("id")] int Id,
        [property: JsonPropertyName("ddd")] string Ddd,
        [property: JsonPropertyName("telefone")] string Telefone,
        [property: JsonPropertyName("nomeOuvidor")] string NomeOuvidor);
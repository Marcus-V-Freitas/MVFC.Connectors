namespace MVFC.Connectors.Financas.Bcb.Modelos.Dtos;

public sealed record BcbOrgaoDto(
        [property: JsonPropertyName("id")] int Id,
        [property: JsonPropertyName("nome")] string Nome,
        [property: JsonPropertyName("administradores")] IReadOnlyList<BcbAdministradorDto> Administradores);
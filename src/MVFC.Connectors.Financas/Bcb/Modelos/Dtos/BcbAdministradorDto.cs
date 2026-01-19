namespace MVFC.Connectors.Financas.Bcb.Modelos.Dtos;

public sealed record BcbAdministradorDto(
        [property: JsonPropertyName("id")] int Id,
        [property: JsonPropertyName("cpf")] string Cpf,
        [property: JsonPropertyName("nome")] string Nome,
        [property: JsonPropertyName("cargo")] string Cargo);
namespace MVFC.Connectors.Financas.Bcb.Modelos.Dtos;

public sealed record BcbCarteiraDto(
        [property: JsonPropertyName("id")] int Id,
        [property: JsonPropertyName("tipo")] string Tipo,
        [property: JsonPropertyName("inicio")] string Inicio);
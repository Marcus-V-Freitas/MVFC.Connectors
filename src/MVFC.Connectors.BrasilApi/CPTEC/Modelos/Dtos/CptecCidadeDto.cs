namespace MVFC.Connectors.BrasilApi.CPTEC.Modelos.Dtos;

public sealed record CptecCidadeDto(
    [property: JsonPropertyName("nome")] string Nome,
    [property: JsonPropertyName("estado")] string Estado,
    [property: JsonPropertyName("id")] int Id);
namespace MVFC.Connectors.BrasilApi.IBGE.Modelos.Dtos;

public sealed record IbgeEstadoDto(
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("sigla")] string Sigla,
    [property: JsonPropertyName("nome")] string Nome,
    [property: JsonPropertyName("regiao")] IbgeRegiaoDto Regiao);
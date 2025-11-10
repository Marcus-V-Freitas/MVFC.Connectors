namespace MVFC.Connectors.BrasilApi.IBGE.Modelos.Dtos;

public sealed record IbgeRegiaoDto(
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("sigla")] string Sigla,
    [property: JsonPropertyName("nome")] string Nome);

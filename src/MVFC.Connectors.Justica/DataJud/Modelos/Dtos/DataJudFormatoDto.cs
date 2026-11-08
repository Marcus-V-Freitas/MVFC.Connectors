namespace MVFC.Connectors.Justica.DataJud.Modelos.Dtos;

public sealed record DataJudFormatoDto(
    [property: JsonPropertyName("codigo")] int Codigo,
    [property: JsonPropertyName("nome")] string Nome);

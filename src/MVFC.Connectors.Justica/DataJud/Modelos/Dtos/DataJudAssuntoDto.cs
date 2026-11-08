namespace MVFC.Connectors.Justica.DataJud.Modelos.Dtos;

public sealed record DataJudAssuntoDto(
    [property: JsonPropertyName("codigo")] int Codigo,
    [property: JsonPropertyName("nome")] string Nome);

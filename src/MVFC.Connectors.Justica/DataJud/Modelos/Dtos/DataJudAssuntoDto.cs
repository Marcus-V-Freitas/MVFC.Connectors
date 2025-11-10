namespace MVFC.Connectors.Justica.DataJud.Modelos;

public sealed record DataJudAssuntoDto(
    [property: JsonPropertyName("codigo")] int Codigo,
    [property: JsonPropertyName("nome")] string Nome);
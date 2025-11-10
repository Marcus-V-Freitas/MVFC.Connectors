namespace MVFC.Connectors.Justica.DataJud.Modelos;

public sealed record DataJudClasseDto(
    [property: JsonPropertyName("codigo")] int Codigo,
    [property: JsonPropertyName("nome")] string Nome);
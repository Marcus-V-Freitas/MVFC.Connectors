namespace MVFC.Connectors.Justica.DataJud.Modelos;

public sealed record DataJudFormatoDto(
    [property: JsonPropertyName("codigo")] int Codigo,
    [property: JsonPropertyName("nome")] string Nome);
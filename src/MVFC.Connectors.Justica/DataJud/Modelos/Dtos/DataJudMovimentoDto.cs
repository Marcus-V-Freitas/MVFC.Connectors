namespace MVFC.Connectors.Justica.DataJud.Modelos.Dtos;

public sealed record DataJudMovimentoDto(
    [property: JsonPropertyName("complementosTabelados")] IReadOnlyList<DataJudTabeladoDto> ComplementosTabelados,
    [property: JsonPropertyName("codigo")] int Codigo,
    [property: JsonPropertyName("nome")] string Nome,
    [property: JsonPropertyName("dataHora")] DateTime DataHora);

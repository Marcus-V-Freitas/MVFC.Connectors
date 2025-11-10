namespace MVFC.Connectors.Justica.DataJud.Modelos;

public sealed record DataJudTabeladoDto(
    [property: JsonPropertyName("codigo")] int Codigo,
    [property: JsonPropertyName("valor")] int Valor,
    [property: JsonPropertyName("nome")] string Nome,
    [property: JsonPropertyName("descricao")] string Descricao);
namespace MVFC.Connectors.BrasilApi.CPTEC.Modelos.Dtos;

public sealed record CptecClimaCidadeDto(
    [property: JsonPropertyName("data")] string Data,
    [property: JsonPropertyName("condicao")] string Condicao,
    [property: JsonPropertyName("min")] int Min,
    [property: JsonPropertyName("max")] int Max,
    [property: JsonPropertyName("indice_uv")] int IndiceUv,
    [property: JsonPropertyName("condicao_desc")] string CondicaoDesc);
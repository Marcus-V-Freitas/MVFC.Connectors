namespace MVFC.Connectors.BrasilApi.CPTEC.Modelos.Dtos;

public sealed record CptecOndaCidadeDto(
    [property: JsonPropertyName("data")] string Data,
    [property: JsonPropertyName("dados_ondas")] IReadOnlyList<CptecDadosOndaDto> DadosOndas);
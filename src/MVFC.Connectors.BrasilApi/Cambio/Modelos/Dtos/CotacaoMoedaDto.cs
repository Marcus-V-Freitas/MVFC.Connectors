namespace MVFC.Connectors.BrasilApi.Cambio.Modelos.Dtos;

public sealed record CotacaoMoedaDto(
    [property: JsonPropertyName("cotacoes")] IReadOnlyList<CotacaoDto> Cotacoes,
    [property: JsonPropertyName("moeda")] string Moeda,
    [property: JsonPropertyName("data")] string Data);
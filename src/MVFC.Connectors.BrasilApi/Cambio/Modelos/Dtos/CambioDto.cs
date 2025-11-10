namespace MVFC.Connectors.BrasilApi.Cambio.Modelos.Dtos;

public sealed record CambioDto(
    [property: JsonPropertyName("simbolo")] string Simbolo,
    [property: JsonPropertyName("nome")] string Nome,
    [property: JsonPropertyName("tipo_moeda")] string TipoMoeda);
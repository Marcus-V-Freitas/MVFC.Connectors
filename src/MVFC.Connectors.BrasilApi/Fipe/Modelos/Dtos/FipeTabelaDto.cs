namespace MVFC.Connectors.BrasilApi.Fipe.Modelos.Dtos;

public sealed record FipeTabelaDto(
    [property: JsonPropertyName("codigo")] int Codigo,
    [property: JsonPropertyName("mes")] string Mes);
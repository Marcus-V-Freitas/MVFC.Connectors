namespace MVFC.Connectors.BrasilApi.Fipe.Modelos.Dtos;

public sealed record FipeMarcaDto(
    [property: JsonPropertyName("nome")] string Nome,
    [property: JsonPropertyName("valor")] string Valor);
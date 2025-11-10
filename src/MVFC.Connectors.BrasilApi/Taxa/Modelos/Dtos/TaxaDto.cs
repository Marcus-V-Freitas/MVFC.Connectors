namespace MVFC.Connectors.BrasilApi.Taxa.Modelos.Dtos;

public sealed record TaxaDto(
    [property: JsonPropertyName("nome")] string Nome,
    [property: JsonPropertyName("valor")] double Valor);
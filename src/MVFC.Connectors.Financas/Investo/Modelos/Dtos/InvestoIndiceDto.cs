namespace MVFC.Connectors.Financas.Investo.Modelos.Dtos;

public sealed record InvestoIndiceDto(
        [property: JsonPropertyName("codigo")] int Codigo,
        [property: JsonPropertyName("nome")] string Nome);
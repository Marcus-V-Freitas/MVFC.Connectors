namespace MVFC.Connectors.BrasilApi.IBGE.Modelos.Dtos;

public sealed record IbgeMunicipioDto(
    [property: JsonPropertyName("nome")] string Nome,
    [property: JsonPropertyName("codigo_ibge")] string CodigoIbge);
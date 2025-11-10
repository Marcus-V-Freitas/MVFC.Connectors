namespace MVFC.Connectors.BrasilApi.CNPJ.Modelos.Dtos;

public sealed record CnaesSecundarioDto(
    [property: JsonPropertyName("codigo")] int Codigo,
    [property: JsonPropertyName("descricao")] string Descricao);
namespace MVFC.Connectors.BrasilApi.NCM.Modelos.Dtos;

public sealed record NcmDto(
    [property: JsonPropertyName("codigo")] string Codigo,
    [property: JsonPropertyName("descricao")] string Descricao,
    [property: JsonPropertyName("data_inicio")] DateTime DataInicio,
    [property: JsonPropertyName("data_fim")] DateTime DataFim,
    [property: JsonPropertyName("tipo_ato")] string TipoAto,
    [property: JsonPropertyName("numero_ato")] string NumeroAto,
    [property: JsonPropertyName("ano_ato")] string AnoAto);
namespace MVFC.Connectors.BrasilApi.CPTEC.Modelos.Dtos;

public sealed record CptecClimaDto(
    [property: JsonPropertyName("codigo_icao")] string CodigoIcao,
    [property: JsonPropertyName("atualizado_em")] DateTime AtualizadoEm,
    [property: JsonPropertyName("pressao_atmosferica")] string PressaoAtmosferica,
    [property: JsonPropertyName("visibilidade")] string Visibilidade,
    [property: JsonPropertyName("vento")] int Vento,
    [property: JsonPropertyName("direcao_vento")] int DirecaoVento,
    [property: JsonPropertyName("umidade")] int Umidade,
    [property: JsonPropertyName("condicao")] string Condicao,
    [property: JsonPropertyName("condicao_Desc")] string CondicaoDesc,
    [property: JsonPropertyName("temp")] decimal Temp);

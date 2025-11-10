namespace MVFC.Connectors.BrasilApi.CPTEC.Modelos.Dtos;

public sealed record CptecDadosOndaDto(
    [property: JsonPropertyName("vento")] double Vento,
    [property: JsonPropertyName("direcao_vento")] string DirecaoVento,
    [property: JsonPropertyName("direcao_vento_desc")] string DirecaoVentoDesc,
    [property: JsonPropertyName("altura_onda")] double AlturaOnda,
    [property: JsonPropertyName("direcao_onda")] string DirecaoOnda,
    [property: JsonPropertyName("direcao_onda_desc")] string DirecaoOndaDesc,
    [property: JsonPropertyName("agitacao")] string Agitacao,
    [property: JsonPropertyName("hora")] string Hora);
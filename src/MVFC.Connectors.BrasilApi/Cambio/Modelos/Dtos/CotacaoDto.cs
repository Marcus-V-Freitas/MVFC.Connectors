namespace MVFC.Connectors.BrasilApi.Cambio.Modelos.Dtos;

public sealed record CotacaoDto(
    [property: JsonPropertyName("paridade_compra")] double ParidadeCompra,
    [property: JsonPropertyName("paridade_venda")] double ParidadeVenda,
    [property: JsonPropertyName("cotacao_compra")] double CotacaoCompra,
    [property: JsonPropertyName("cotacao_venda")] double CotacaoVenda,
    [property: JsonPropertyName("data_hora_cotacao")] string DataHoraCotacao,
    [property: JsonPropertyName("tipo_boletim")] string TipoBoletim);
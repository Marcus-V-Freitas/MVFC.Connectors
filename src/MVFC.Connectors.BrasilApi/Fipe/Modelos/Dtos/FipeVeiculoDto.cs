namespace MVFC.Connectors.BrasilApi.Fipe.Modelos.Dtos;

public sealed record FipeVeiculoDto(
    [property: JsonPropertyName("valor")] string Valor,
    [property: JsonPropertyName("marca")] string Marca,
    [property: JsonPropertyName("modelo")] string Modelo,
    [property: JsonPropertyName("anoModelo")] int AnoModelo,
    [property: JsonPropertyName("combustivel")] string Combustivel,
    [property: JsonPropertyName("codigoFipe")] string CodigoFipe,
    [property: JsonPropertyName("mesReferencia")] string MesReferencia,
    [property: JsonPropertyName("tipoVeiculo")] int TipoVeiculo,
    [property: JsonPropertyName("siglaCombustivel")] string SiglaCombustivel,
    [property: JsonPropertyName("dataConsulta")] string DataConsulta);
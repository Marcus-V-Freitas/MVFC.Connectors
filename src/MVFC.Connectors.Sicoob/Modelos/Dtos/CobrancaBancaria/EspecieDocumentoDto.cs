namespace MVFC.Connectors.Sicoob.Modelos.Dtos.CobrancaBancaria;

public sealed record EspecieDocumentoDto(
    [property: JsonPropertyName("codigoEspecieDocumento")] EspecieDocumento CodigoEspecieDocumento);
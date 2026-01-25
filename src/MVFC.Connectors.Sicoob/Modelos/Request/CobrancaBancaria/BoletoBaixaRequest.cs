namespace MVFC.Connectors.Sicoob.Modelos.Request.CobrancaBancaria;

public sealed record BoletoBaixaRequest(
    [property: JsonPropertyName("numeroCliente")] int NumeroCliente,
    [property: JsonPropertyName("codigoModalidade")] ModalidadeBoleto CodigoModalidade);
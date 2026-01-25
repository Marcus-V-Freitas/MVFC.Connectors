namespace MVFC.Connectors.Sicoob.Modelos.Request.CobrancaBancaria;

public sealed record ProtestoRequest(
    [property: JsonPropertyName("numeroCliente")] int NumeroCliente,
    [property: JsonPropertyName("codigoModalidade")] ModalidadeBoleto CodigoModalidade);
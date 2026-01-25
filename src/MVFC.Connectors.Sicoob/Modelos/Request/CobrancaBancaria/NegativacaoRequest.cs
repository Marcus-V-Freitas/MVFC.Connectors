namespace MVFC.Connectors.Sicoob.Modelos.Request.CobrancaBancaria;

public sealed record NegativacaoRequest(
    [property: JsonPropertyName("numeroCliente")] int NumeroCliente,
    [property: JsonPropertyName("codigoModalidade")] ModalidadeBoleto CodigoModalidade);
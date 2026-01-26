namespace MVFC.Connectors.Sicoob.Modelos.Query.CobrancaBancaria;

public sealed record BoletoConsultaQuery(
    [property: AliasAs("numeroCliente")] int NumeroCliente,
    [property: AliasAs(null!)] ModalidadeBoleto CodigoModalidade,
    [property: AliasAs("nossoNumero")] int? NossoNumero = null,
    [property: AliasAs("linhaDigitavel")] string? LinhaDigitavel = null,
    [property: AliasAs("codigoBarras")] string? CodigoBarras = null,
    [property: AliasAs("numeroContratoCobranca")] long? NumeroContratoCobranca = null)
{
    [AliasAs("codigoModalidade")]
    public int CodigoModalidadeValue => (int)CodigoModalidade;
}
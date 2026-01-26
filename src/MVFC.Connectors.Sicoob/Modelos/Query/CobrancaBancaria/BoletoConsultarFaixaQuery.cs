namespace MVFC.Connectors.Sicoob.Modelos.Query.CobrancaBancaria;

public sealed record BoletoConsultarFaixaQuery(
    [property: AliasAs("numeroCliente")] int NumeroCliente,
    [property: AliasAs(null!)] ModalidadeBoleto CodigoModalidade,
    [property: AliasAs("quantidade")] int Quantidade,
    [property: AliasAs("numeroContratoCobranca")] long? NumeroContratoCobranca = null)
{
    [AliasAs("codigoModalidade")]
    public int CodigoModalidadeValue => (int)CodigoModalidade;
}
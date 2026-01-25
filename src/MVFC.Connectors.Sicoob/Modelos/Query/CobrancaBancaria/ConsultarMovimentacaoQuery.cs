namespace MVFC.Connectors.Sicoob.Modelos.Query.CobrancaBancaria;

public sealed record ConsultarMovimentacaoQuery(
    [property: AliasAs("numeroCliente")] int NumeroCliente, 
    [property: AliasAs("codigoSolicitacao")] int CodigoSolicitacao);
namespace MVFC.Connectors.Sicoob.Modelos.Query.CobrancaBancaria;

public sealed record DownloadMovimentacaoQuery(
    [property: AliasAs("numeroCliente")] int NumeroCliente, 
    [property: AliasAs("codigoSolicitacao")] int CodigoSolicitacao, 
    [property: AliasAs("idArquivo")] int IdArquivo);
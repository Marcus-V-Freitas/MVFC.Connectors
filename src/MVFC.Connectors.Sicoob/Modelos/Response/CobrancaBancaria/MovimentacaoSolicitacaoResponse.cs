namespace MVFC.Connectors.Sicoob.Modelos.Response.CobrancaBancaria;

public sealed record MovimentacaoSolicitacaoResponse(
    [property: JsonPropertyName("mensagem")] string Mensagem,
    [property: JsonPropertyName("codigoSolicitacao")] int CodigoSolicitacao);
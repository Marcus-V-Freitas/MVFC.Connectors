namespace MVFC.Connectors.Financas.Bcb.Modelos.Dtos;

public sealed record BcbPixProdutoParticipanteDto(
        [property: JsonPropertyName("id")] int Id,
        [property: JsonPropertyName("codigoProduto")] int CodigoProduto,
        [property: JsonPropertyName("produto")] string Produto,
        [property: JsonPropertyName("ativo")] string Ativo,
        [property: JsonPropertyName("produtoOfertadoPJ")] string ProdutoOfertadoPJ,
        [property: JsonPropertyName("tipoProdutoOfertadoPJ")] string TipoProdutoOfertadoPJ,
        [property: JsonPropertyName("produtoOfertadoPF")] string ProdutoOfertadoPF,
        [property: JsonPropertyName("tipoProdutoOfertadoPF")] string TipoProdutoOfertadoPF,
        [property: JsonPropertyName("pessoaJuridicaResource")] object PessoaJuridicaResource,
        [property: JsonPropertyName("nomeProdutoOfertadoPJ")] object NomeProdutoOfertadoPJ,
        [property: JsonPropertyName("nomeProdutoOfertadoPF")] object NomeProdutoOfertadoPF);
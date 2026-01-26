namespace MVFC.Connectors.Sicoob.Modelos.Response.CobrancaBancariaPagamento;

public sealed record ComprovanteResponse(
    [property: JsonPropertyName("idPagamento")] long IdPagamento,
    [property: JsonPropertyName("dataHoraCadastro")] DateTime DataHoraCadastro,
    [property: JsonPropertyName("dataPagamento")] DateOnly DataPagamento,
    [property: JsonPropertyName("situacaoPagamento")] SituacaoPagamento SituacaoPagamento,
    [property: JsonPropertyName("nomeAgencia")] string NomeAgencia,
    [property: JsonPropertyName("nomeInstituicaoEmissora")] string NomeInstituicaoEmissora,
    [property: JsonPropertyName("numeroInstituicaoEmissora")] int NumeroInstituicaoEmissora,
    [property: JsonPropertyName("valorBoleto")] decimal ValorBoleto,
    [property: JsonPropertyName("valorPagamento")] decimal ValorPagamento,
    [property: JsonPropertyName("valorMultaMora")] decimal ValorMultaMora,
    [property: JsonPropertyName("valorAbatimentoDesconto")] decimal ValorAbatimentoDesconto,
    [property: JsonPropertyName("numeroLinhaDigitavel")] string NumeroLinhaDigitavel,
    [property: JsonPropertyName("dataVencimento")] DateOnly DataVencimento,
    [property: JsonPropertyName("aceitaValorDivergente")] bool AceitaValorDivergente,
    [property: JsonPropertyName("descricaoOuvidoria")] string DescricaoOuvidoria,
    [property: JsonPropertyName("descricaoDetalheSituacao")] string DescricaoDetalheSituacao,
    [property: JsonPropertyName("descricaoTituloComprovante")] TituloComprovante DescricaoTituloComprovante)
{
    [JsonPropertyName("numeroAgencia")]
    public string? NumeroAgencia { get; init; }

    [JsonPropertyName("numeroConta")]
    public long? NumeroConta { get; init; }

    [JsonPropertyName("nomeProprietarioContaCorrente")]
    public string? NomeProprietarioContaCorrente { get; init; }

    [JsonPropertyName("numeroCpfCnpjBeneficiario")]
    public string? NumeroCpfCnpjBeneficiario { get; init; }

    [JsonPropertyName("nomeRazaoSocialBeneficiario")]
    public string? NomeRazaoSocialBeneficiario { get; init; }

    [JsonPropertyName("nomeFantasiaBeneficiario")]
    public string? NomeFantasiaBeneficiario { get; init; }

    [JsonPropertyName("numeroCpfCnpjBeneficiarioFinal")]
    public string? NumeroCpfCnpjBeneficiarioFinal { get; init; }

    [JsonPropertyName("nomeRazaoSocialBeneficiarioFinal")]
    public string? NomeRazaoSocialBeneficiarioFinal { get; init; }

    [JsonPropertyName("nomeFantasiaBeneficiarioFinal")]
    public string? NomeFantasiaBeneficiarioFinal { get; init; }

    [JsonPropertyName("numeroCpfCnpjPagador")]
    public string? NumeroCpfCnpjPagador { get; init; }

    [JsonPropertyName("nomeRazaoSocialPagador")]
    public string? NomeRazaoSocialPagador { get; init; }

    [JsonPropertyName("nomeFantasiaPagador")]
    public string? NomeFantasiaPagador { get; init; }

    [JsonPropertyName("nossoNumero")]
    public string? NossoNumero { get; init; }

    [JsonPropertyName("numeroDocumento")]
    public string? NumeroDocumento { get; init; }

    [JsonPropertyName("descricaoObservacao")]
    public string? DescricaoObservacao { get; init; }

    [JsonPropertyName("numeroAutenticacaoPagamento")]
    public string? NumeroAutenticacaoPagamento { get; init; }
}
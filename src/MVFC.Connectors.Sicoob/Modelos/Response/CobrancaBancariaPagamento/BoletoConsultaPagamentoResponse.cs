namespace MVFC.Connectors.Sicoob.Modelos.Response.CobrancaBancariaPagamento;

public sealed record BoletoConsultaPagamentoResponse(
    [property: JsonPropertyName("codigoBarras")] string CodigoBarras,
    [property: JsonPropertyName("numeroLinhaDigitavel")] string NumeroLinhaDigitavel,
    [property: JsonPropertyName("numeroInstituicaoEmissora")] int NumeroInstituicaoEmissora,
    [property: JsonPropertyName("nomeInstituicaoEmissora")] string NomeInstituicaoEmissora,
    [property: JsonPropertyName("descricaoInstrucaoValorMinMax")] string DescricaoInstrucaoValorMinMax,
    [property: JsonPropertyName("valorPagamento")] decimal ValorPagamento,
    [property: JsonPropertyName("valorAbatimentoDesconto")] decimal ValorAbatimentoDesconto,
    [property: JsonPropertyName("valorMultaMora")] decimal ValorMultaMora,
    [property: JsonPropertyName("bloquearPagamento")] bool BloquearPagamento,
    [property: JsonPropertyName("permiteAlterarValor")] bool PermiteAlterarValor,
    [property: JsonPropertyName("valorBoleto")] decimal ValorBoleto,
    [property: JsonPropertyName("dataPagamento")] DateOnly DataPagamento,
    [property: JsonPropertyName("dataVencimentoBoleto")] DateOnly DataVencimentoBoleto,
    [property: JsonPropertyName("consultaEmContingencia")] bool ConsultaEmContingencia)
{
    [JsonPropertyName("tipoPessoaBeneficiario")]
    public TipoPessoaStr? TipoPessoaBeneficiario { get; init; }

    [JsonPropertyName("numeroCpfCnpjBeneficiario")]
    public string? NumeroCpfCnpjBeneficiario { get; init; }

    [JsonPropertyName("nomeRazaoSocialBeneficiario")]
    public string? NomeRazaoSocialBeneficiario { get; init; }

    [JsonPropertyName("nomeFantasiaBeneficiario")]
    public string? NomeFantasiaBeneficiario { get; init; }

    [JsonPropertyName("tipoPessoaBeneficiarioFinal")]
    public TipoPessoaStr? TipoPessoaBeneficiarioFinal { get; init; }

    [JsonPropertyName("numeroCpfCnpjBeneficiarioFinal")]
    public string? NumeroCpfCnpjBeneficiarioFinal { get; init; }

    [JsonPropertyName("nomeRazaoSocialBeneficiarioFinal")]
    public string? NomeRazaoSocialBeneficiarioFinal { get; init; }

    [JsonPropertyName("nomeFantasiaBeneficiarioFinal")]
    public string? NomeFantasiaBeneficiarioFinal { get; init; }

    [JsonPropertyName("tipoPessoaPagador")]
    public TipoPessoaStr? TipoPessoaPagador { get; init; }

    [JsonPropertyName("numeroCpfCnpjPagador")]
    public string? NumeroCpfCnpjPagador { get; init; }

    [JsonPropertyName("nomeRazaoSocialPagador")]
    public string? NomeRazaoSocialPagador { get; init; }

    [JsonPropertyName("nomeFantasiaPagador")]
    public string? NomeFantasiaPagador { get; init; }

    [JsonPropertyName("dataLimitePagamentoBoleto")]
    public DateOnly? DataLimitePagamentoBoleto { get; init; }

    [JsonPropertyName("codigoEspecieDocumento")]
    public int? CodigoEspecieDocumento { get; init; }

    [JsonPropertyName("codigoSituacaoBoletoPagamento")]
    public string? CodigoSituacaoBoletoPagamento { get; init; }

    [JsonPropertyName("nossoNumero")]
    public string? NossoNumero { get; init; }

    [JsonPropertyName("numeroDocumento")]
    public string? NumeroDocumento { get; init; }

    [JsonPropertyName("identificadorConsulta")]
    public string? IdentificadorConsulta { get; init; }

    [JsonPropertyName("descricaoInstrucaoDesconto1")]
    public string? DescricaoInstrucaoDesconto1 { get; init; }

    [JsonPropertyName("descricaoInstrucaoDesconto2")]
    public string? DescricaoInstrucaoDesconto2 { get; init; }

    [JsonPropertyName("descricaoInstrucaoDesconto3")]
    public string? DescricaoInstrucaoDesconto3 { get; init; }

    [JsonPropertyName("mensagemBloqueioPagamento")]
    public string? MensagemBloqueioPagamento { get; init; }
}
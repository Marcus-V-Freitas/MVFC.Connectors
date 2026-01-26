namespace MVFC.Connectors.Sicoob.Modelos.Response.CobrancaBancariaPagamento;

public sealed record BoletoDdaResponse(
    [property: JsonPropertyName("descricaoTipoPagador")] string DescricaoTipoPagador,
    [property: JsonPropertyName("tipoPessoaBeneficiario")] TipoPessoaStr TipoPessoaBeneficiario,
    [property: JsonPropertyName("numeroCpfCnpjBeneficiario")] string NumeroCpfCnpjBeneficiario,
    [property: JsonPropertyName("nomeRazaoSocialBeneficiario")] string NomeRazaoSocialBeneficiario,
    [property: JsonPropertyName("tipoPessoaPagador")] TipoPessoaStr TipoPessoaPagador,
    [property: JsonPropertyName("numeroCpfCnpjPagador")] string NumeroCpfCnpjPagador,
    [property: JsonPropertyName("nomeRazaoSocialPagador")] string NomeRazaoSocialPagador,
    [property: JsonPropertyName("valorBoleto")] decimal ValorBoleto,
    [property: JsonPropertyName("dataVencimentoBoleto")] string DataVencimentoBoleto,
    [property: JsonPropertyName("codigoTipoSituacaoBoleto")] int CodigoTipoSituacaoBoleto,
    [property: JsonPropertyName("descricaoSituacaoBoleto")] string DescricaoSituacaoBoleto,
    [property: JsonPropertyName("numeroIdentificadorBoletoCip")] long NumeroIdentificadorBoletoCip,
    [property: JsonPropertyName("numeroCodigoBarras")] string NumeroCodigoBarras)
{
    [JsonPropertyName("nomeFantasiaPagador")]
    public string? NomeFantasiaPagador { get; init; }

    [JsonPropertyName("descricaoLogradouroPagador")]
    public string? DescricaoLogradouroPagador { get; init; }

    [JsonPropertyName("descricaoCidadePagador")]
    public string? DescricaoCidadePagador { get; init; }

    [JsonPropertyName("siglaUfPagador")]
    public string? SiglaUfPagador { get; init; }

    [JsonPropertyName("numeroCepPagador")]
    public string? NumeroCepPagador { get; init; }

    [JsonPropertyName("tipoPessoaAvalista")]
    public TipoPessoaStr? TipoPessoaAvalista { get; init; }

    [JsonPropertyName("numeroCpfCnpjAvalista")]
    public string? NumeroCpfCnpjAvalista { get; init; }

    [JsonPropertyName("nomeAvalista")]
    public string? NomeAvalista { get; init; }

    [JsonPropertyName("numeroCpfCnpjPagadorEletronico")]
    public string? NumeroCpfCnpjPagadorEletronico { get; init; }

    [JsonPropertyName("aceite")]
    public bool? Aceite { get; init; }

    [JsonPropertyName("numeroNossoNumero")]
    public string? NumeroNossoNumero { get; init; }

    [JsonPropertyName("numeroDocumento")]
    public string? NumeroDocumento { get; init; }

    [JsonPropertyName("dataPagamento")]
    public string? DataPagamento { get; init; }

    [JsonPropertyName("valorPagamento")]
    public decimal? ValorPagamento { get; init; }

    [JsonPropertyName("codigoEspecieDocumento")]
    public int? CodigoEspecieDocumento { get; init; }

    [JsonPropertyName("dataEmissao")]
    public string? DataEmissao { get; init; }

    [JsonPropertyName("dataLimitePagamento")]
    public string? DataLimitePagamento { get; init; }

    [JsonPropertyName("codigoTipoJuros")]
    public int? CodigoTipoJuros { get; init; }

    [JsonPropertyName("dataJuros")]
    public string? DataJuros { get; init; }

    [JsonPropertyName("valorPercentualJuros")]
    public decimal? ValorPercentualJuros { get; init; }

    [JsonPropertyName("codigoTipoMulta")]
    public int? CodigoTipoMulta { get; init; }

    [JsonPropertyName("dataMulta")]
    public string? DataMulta { get; init; }

    [JsonPropertyName("valorPercentualMulta")]
    public decimal? ValorPercentualMulta { get; init; }

    [JsonPropertyName("valorAbatimento")]
    public decimal? ValorAbatimento { get; init; }

    [JsonPropertyName("codigoTipoDesconto1")]
    public string? CodigoTipoDesconto1 { get; init; }

    [JsonPropertyName("dataDesconto1")]
    public string? DataDesconto1 { get; init; }

    [JsonPropertyName("valorPercentualDesconto1")]
    public decimal? ValorPercentualDesconto1 { get; init; }

    [JsonPropertyName("codigoTipoDesconto2")]
    public string? CodigoTipoDesconto2 { get; init; }

    [JsonPropertyName("dataDesconto2")]
    public string? DataDesconto2 { get; init; }

    [JsonPropertyName("valorPercentualDesconto2")]
    public decimal? ValorPercentualDesconto2 { get; init; }

    [JsonPropertyName("codigoTipoDesconto3")]
    public string? CodigoTipoDesconto3 { get; init; }

    [JsonPropertyName("dataDesconto3")]
    public string? DataDesconto3 { get; init; }

    [JsonPropertyName("valorPercentualDesconto3")]
    public decimal? ValorPercentualDesconto3 { get; init; }

    [JsonPropertyName("numeroDiasProtesto")]
    public int? NumeroDiasProtesto { get; init; }

    [JsonPropertyName("quantidadePagamentoParcial")]
    public int? QuantidadePagamentoParcial { get; init; }

    [JsonPropertyName("codigoAutorizacaoValorDivergente")]
    public int? CodigoAutorizacaoValorDivergente { get; init; }

    [JsonPropertyName("codigoIndicadorValorMaximo")]
    public string? CodigoIndicadorValorMaximo { get; init; }

    [JsonPropertyName("valorPercentualMaximo")]
    public decimal? ValorPercentualMaximo { get; init; }

    [JsonPropertyName("codigoIndicadorValorMinimo")]
    public string? CodigoIndicadorValorMinimo { get; init; }

    [JsonPropertyName("valorPercentualMinimo")]
    public decimal? ValorPercentualMinimo { get; init; }
}
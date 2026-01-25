namespace MVFC.Connectors.Sicoob.Modelos.Response.CobrancaBancaria;

public sealed record BoletoResponse(
    [property: JsonPropertyName("numeroCliente")] int NumeroCliente,
    [property: JsonPropertyName("codigoModalidade")] ModalidadeBoleto CodigoModalidade,
    [property: JsonPropertyName("numeroContaCorrente")] int NumeroContaCorrente,
    [property: JsonPropertyName("codigoEspecieDocumento")] EspecieDocumento CodigoEspecieDocumento,
    [property: JsonPropertyName("dataEmissao")] DateOnly DataEmissao,
    [property: JsonPropertyName("nossoNumero")] int NossoNumero,
    [property: JsonPropertyName("seuNumero")] string SeuNumero,
    [property: JsonPropertyName("codigoBarras")] string CodigoBarras,
    [property: JsonPropertyName("linhaDigitavel")] string LinhaDigitavel,
    [property: JsonPropertyName("identificacaoEmissaoBoleto")] IdentificacaoEmissao IdentificacaoEmissaoBoleto,
    [property: JsonPropertyName("valor")] decimal Valor,
    [property: JsonPropertyName("numeroParcela")] int NumeroParcela,
    [property: JsonPropertyName("aceite")] bool Aceite,
    [property: JsonPropertyName("codigoProtesto")] CodigoProtesto CodigoProtesto,
    [property: JsonPropertyName("codigoNegativacao")] CodigoNegativacao CodigoNegativacao,
    [property: JsonPropertyName("tipoDesconto")] TipoDesconto TipoDesconto,
    [property: JsonPropertyName("dataVencimento")] DateOnly DataVencimento,
    [property: JsonPropertyName("valorAbatimento")] decimal ValorAbatimento,
    [property: JsonPropertyName("tipoMulta")] TipoMulta TipoMulta,
    [property: JsonPropertyName("dataMulta")] DateOnly DataMulta,
    [property: JsonPropertyName("valorMulta")] decimal ValorMulta,
    [property: JsonPropertyName("tipoJurosMora")] TipoJurosMora TipoJurosMora,
    [property: JsonPropertyName("dataJurosMora")] DateOnly DataJurosMora,
    [property: JsonPropertyName("valorJurosMora")] decimal ValorJurosMora)
{
    [JsonPropertyName("identificacaoBoletoEmpresa")]
    public string? IdentificacaoBoletoEmpresa { get; init; }

    [JsonPropertyName("identificacaoDistribuicaoBoleto")]
    public IdentificacaoDistribuicao? IdentificacaoDistribuicaoBoleto { get; init; }

    [JsonPropertyName("dataLimitePagamento")]
    public DateOnly? DataLimitePagamento { get; init; }

    [JsonPropertyName("dataPrimeiroDesconto")]
    public DateOnly? DataPrimeiroDesconto { get; init; }

    [JsonPropertyName("valorPrimeiroDesconto")]
    public decimal? ValorPrimeiroDesconto { get; init; }

    [JsonPropertyName("dataSegundoDesconto")]
    public DateOnly? DataSegundoDesconto { get; init; }

    [JsonPropertyName("valorSegundoDesconto")]
    public decimal? ValorSegundoDesconto { get; init; }

    [JsonPropertyName("dataTerceiroDesconto")]
    public DateOnly? DataTerceiroDesconto { get; init; }

    [JsonPropertyName("valorTerceiroDesconto")]
    public decimal? ValorTerceiroDesconto { get; init; }

    [JsonPropertyName("numeroDiasNegativacao")]
    public int? NumeroDiasNegativacao { get; init; }

    [JsonPropertyName("numeroDiasProtesto")]
    public int? NumeroDiasProtesto { get; init; }

    [JsonPropertyName("quantidadeDiasFloat")]
    public int? QuantidadeDiasFloat { get; init; }

    [JsonPropertyName("pagador")]
    public PagadorResponse? Pagador { get; init; }

    [JsonPropertyName("beneficiarioFinal")]
    public BeneficiarioFinalResponse? BeneficiarioFinal { get; init; }

    [JsonPropertyName("mensagensInstrucao")]
    public string[]? MensagensInstrucao { get; init; }

    [JsonPropertyName("rateioCreditos")]
    public RateioCreditoDto[]? RateioCreditos { get; init; }

    [JsonPropertyName("pdfBoleto")]
    public string? PdfBoleto { get; init; }

    [JsonPropertyName("qrCode")]
    public string? QrCode { get; init; }

    [JsonPropertyName("numeroContratoCobranca")]
    public long? NumeroContratoCobranca { get; init; }

    [JsonPropertyName("descricaoRejeicaoPix")]
    public string? DescricaoRejeicaoPix { get; init; }

    [JsonPropertyName("situacaoBoleto")]
    public SituacaoBoleto? SituacaoBoleto { get; init; }
}
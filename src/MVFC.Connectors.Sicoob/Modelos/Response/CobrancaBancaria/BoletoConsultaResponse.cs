namespace MVFC.Connectors.Sicoob.Modelos.Response.CobrancaBancaria;

public sealed record BoletoConsultaResponse(
    [property: JsonPropertyName("numeroCliente")] int NumeroCliente,
    [property: JsonPropertyName("codigoModalidade")] ModalidadeBoleto CodigoModalidade,
    [property: JsonPropertyName("situacaoBoleto")] SituacaoBoleto SituacaoBoleto,
    [property: JsonPropertyName("codigoEspecieDocumento")] EspecieDocumento CodigoEspecieDocumento,
    [property: JsonPropertyName("dataEmissao")] DateOnly DataEmissao,
    [property: JsonPropertyName("nossoNumero")] int NossoNumero,
    [property: JsonPropertyName("seuNumero")] string SeuNumero,
    [property: JsonPropertyName("identificacaoBoletoEmpresa")] string IdentificacaoBoletoEmpresa,
    [property: JsonPropertyName("codigoBarras")] string CodigoBarras,
    [property: JsonPropertyName("linhaDigitavel")] string LinhaDigitavel,
    [property: JsonPropertyName("valor")] decimal Valor,
    [property: JsonPropertyName("dataVencimento")] DateOnly DataVencimento,
    [property: JsonPropertyName("numeroParcela")] int NumeroParcela,
    [property: JsonPropertyName("aceite")] bool Aceite,
    [property: JsonPropertyName("quantidadeDiasFloat")] int QuantidadeDiasFloat,
    [property: JsonPropertyName("valorAbatimento")] decimal ValorAbatimento,
    [property: JsonPropertyName("tipoDesconto")] TipoDesconto TipoDesconto,
    [property: JsonPropertyName("tipoMulta")] TipoMulta TipoMulta,
    [property: JsonPropertyName("valorMulta")] decimal ValorMulta,
    [property: JsonPropertyName("tipoJurosMora")] TipoJurosMora TipoJurosMora,
    [property: JsonPropertyName("valorJurosMora")] decimal ValorJurosMora,
    [property: JsonPropertyName("pagador")] PagadorResponse Pagador)
{
    [JsonPropertyName("numeroContaCorrente")]
    public int? NumeroContaCorrente { get; init; }

    [JsonPropertyName("identificacaoEmissaoBoleto")]
    public IdentificacaoEmissao? IdentificacaoEmissaoBoleto { get; init; }

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

    [JsonPropertyName("dataMulta")]
    public DateOnly? DataMulta { get; init; }

    [JsonPropertyName("dataJurosMora")]
    public DateOnly? DataJurosMora { get; init; }

    [JsonPropertyName("codigoNegativacao")]
    public CodigoNegativacao? CodigoNegativacao { get; init; }

    [JsonPropertyName("numeroDiasNegativacao")]
    public int? NumeroDiasNegativacao { get; init; }

    [JsonPropertyName("codigoProtesto")]
    public CodigoProtesto? CodigoProtesto { get; init; }

    [JsonPropertyName("numeroDiasProtesto")]
    public int? NumeroDiasProtesto { get; init; }

    [JsonPropertyName("beneficiarioFinal")]
    public BeneficiarioFinalResponse? BeneficiarioFinal { get; init; }

    [JsonPropertyName("mensagensInstrucao")]
    public string[]? MensagensInstrucao { get; init; }

    [JsonPropertyName("rateioCreditos")]
    public RateioCreditoDto[]? RateioCreditos { get; init; }

    [JsonPropertyName("qrCode")]
    public string? QrCode { get; init; }

    [JsonPropertyName("numeroContratoCobranca")]
    public long? NumeroContratoCobranca { get; init; }
}
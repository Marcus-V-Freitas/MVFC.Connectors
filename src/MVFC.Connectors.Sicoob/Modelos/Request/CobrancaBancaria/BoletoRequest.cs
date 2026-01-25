namespace MVFC.Connectors.Sicoob.Modelos.Request.CobrancaBancaria;

public sealed record BoletoRequest(
    [property: JsonPropertyName("numeroCliente")] int NumeroCliente,
    [property: JsonPropertyName("codigoModalidade")] ModalidadeBoleto CodigoModalidade,
    [property: JsonPropertyName("numeroContaCorrente")] int NumeroContaCorrente,
    [property: JsonPropertyName("codigoEspecieDocumento")] EspecieDocumento CodigoEspecieDocumento,
    [property: JsonPropertyName("identificacaoEmissaoBoleto")] IdentificacaoEmissao IdentificacaoEmissaoBoleto,
    [property: JsonPropertyName("identificacaoDistribuicaoBoleto")] IdentificacaoDistribuicao IdentificacaoDistribuicaoBoleto,
    [property: JsonPropertyName("dataEmissao")] DateOnly DataEmissao,
    [property: JsonPropertyName("seuNumero")] string SeuNumero,
    [property: JsonPropertyName("valor")] decimal Valor,
    [property: JsonPropertyName("dataVencimento")] DateOnly DataVencimento,
    [property: JsonPropertyName("tipoDesconto")] TipoDesconto TipoDesconto,
    [property: JsonPropertyName("numeroParcela")] int NumeroParcela,
    [property: JsonPropertyName("aceite")] bool Aceite,
    [property: JsonPropertyName("tipoMulta")] TipoMulta TipoMulta,
    [property: JsonPropertyName("tipoJurosMora")] TipoJurosMora TipoJurosMora,
    [property: JsonPropertyName("codigoNegativacao")] CodigoNegativacao CodigoNegativacao,
    [property: JsonPropertyName("codigoProtesto")] CodigoProtesto CodigoProtesto,
    [property: JsonPropertyName("pagador")] PagadorRequest Pagador)
{
    [JsonPropertyName("identificacaoBoletoEmpresa")]
    public string? IdentificacaoBoletoEmpresa { get; init; }
    
    [JsonPropertyName("dataLimitePagamento")]
    public DateOnly? DataLimitePagamento { get; init; }
    
    [JsonPropertyName("valorAbatimento")]
    public decimal ValorAbatimento { get; init; }
    
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
    
    [JsonPropertyName("valorMulta")]
    public decimal? ValorMulta { get; init; }
    
    [JsonPropertyName("dataJurosMora")]
    public DateOnly? DataJurosMora { get; init; }
    
    [JsonPropertyName("valorJurosMora")]
    public decimal? ValorJurosMora { get; init; }
    
    [JsonPropertyName("numeroDiasNegativacao")]
    public int? NumeroDiasNegativacao { get; init; }
    
    [JsonPropertyName("numeroDiasProtesto")]
    public int? NumeroDiasProtesto { get; init; }
    
    [JsonPropertyName("quantidadeDiasFloat")]
    public int? QuantidadeDiasFloat { get; init; }
    
    [JsonPropertyName("beneficiarioFinal")]
    public BeneficiarioFinalRequest? BeneficiarioFinal { get; init; }
    
    [JsonPropertyName("mensagensInstrucao")]
    public string[]? MensagensInstrucao { get; init; }
    
    [JsonPropertyName("rateioCreditos")]
    public RateioCreditoDto[]? RateioCreditos { get; init; }
    
    [JsonPropertyName("numeroContratoCobranca")]
    public long? NumeroContratoCobranca { get; init; }
}
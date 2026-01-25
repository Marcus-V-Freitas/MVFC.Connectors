namespace MVFC.Connectors.Sicoob.Modelos.Request.CobrancaBancaria;

public sealed record BoletoAlteracaoRequest(
    [property: JsonPropertyName("numeroCliente")] int NumeroCliente,
    [property: JsonPropertyName("codigoModalidade")] ModalidadeBoleto CodigoModalidade)
{
    [JsonPropertyName("especieDocumento")]
    public EspecieDocumentoDto? EspecieDocumento { get; init; }

    [JsonPropertyName("seuNumero")]
    public SeuNumeroAlteracaoDto? SeuNumero { get; init; }

    [JsonPropertyName("desconto")]
    public DescontoAlteracaoDto? Desconto { get; init; }

    [JsonPropertyName("abatimento")]
    public AbatimentoAlteracaoDto? Abatimento { get; init; }

    [JsonPropertyName("multa")]
    public MultaAlteracaoDto? Multa { get; init; }

    [JsonPropertyName("jurosMora")]
    public JurosMoraAlteracao? JurosMora { get; init; }

    [JsonPropertyName("rateioCredito")]
    public RateioCreditoAlteracaoDto? RateioCredito { get; init; }

    [JsonPropertyName("pix")]
    public PixAlteracaoDto? Pix { get; init; }

    [JsonPropertyName("prorrogacaoVencimento")]
    public ProrrogacaoVencimento? ProrrogacaoVencimento { get; init; }

    [JsonPropertyName("prorrogacaoLimitePagamento")]
    public ProrrogacaoLimitePagamentoDto? ProrrogacaoLimitePagamento { get; init; }

    [JsonPropertyName("valorNominal")]
    public ValorNominalAlteracaoDto? ValorNominal { get; init; }
}
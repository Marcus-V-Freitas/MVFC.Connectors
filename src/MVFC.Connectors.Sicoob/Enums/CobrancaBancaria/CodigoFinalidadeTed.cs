namespace MVFC.Connectors.Sicoob.Enums.CobrancaBancaria;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum CodigoFinalidadeTed
{
    [JsonStringEnumMemberName("1")]
    PagamentoDeImpostosTributosTaxas = 1,
    [JsonStringEnumMemberName("2")]
    PagamentoConcessionariasDeServicoPublico = 2,
    [JsonStringEnumMemberName("3")]
    PagamentosDeDividendos = 3,
    [JsonStringEnumMemberName("4")]
    PagamentoDeSalarios = 4,
    [JsonStringEnumMemberName("5")]
    PagamentoDeFornecedores = 5,
    [JsonStringEnumMemberName("6")]
    PagamentoDeHonorarios = 6,
    [JsonStringEnumMemberName("7")]
    PagamentoDeAluguéisTaxasDeCondomínio = 7,
    [JsonStringEnumMemberName("8")]
    PagamentoDeDuplicatasTitulos = 8,
    [JsonStringEnumMemberName("9")]
    PagamentoDeMensalidadeEscolar = 9,
    [JsonStringEnumMemberName("10")]
    CreditoEmConta = 10,
    [JsonStringEnumMemberName("99999")]
    Outros = 99999,
}
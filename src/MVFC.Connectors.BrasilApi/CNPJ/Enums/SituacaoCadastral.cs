namespace MVFC.Connectors.BrasilApi.CNPJ.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum SituacaoCadastral
{
    [JsonStringEnumMemberName("NULA")]
    Nula = 1,
    [JsonStringEnumMemberName("ATIVA")]
    Ativa = 2,
    [JsonStringEnumMemberName("SUSPENSA")]
    Suspensa = 3,
    [JsonStringEnumMemberName("INAPTA")]
    Inapta = 4,
    [JsonStringEnumMemberName("BAIXADA")]
    Baixada = 5,
}

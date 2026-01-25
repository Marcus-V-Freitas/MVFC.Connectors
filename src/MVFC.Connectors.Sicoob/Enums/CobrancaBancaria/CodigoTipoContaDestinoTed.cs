namespace MVFC.Connectors.Sicoob.Enums.CobrancaBancaria;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum CodigoTipoContaDestinoTed
{
    [JsonStringEnumMemberName("CC")]
    ContaCorrente,
    [JsonStringEnumMemberName("CD")]
    ContaDeDepósito,
    [JsonStringEnumMemberName("CG")]
    ContaGarantida,
}
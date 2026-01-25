namespace MVFC.Connectors.Sicoob.Enums.CobrancaBancaria;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum SituacaoBoleto
{
    [JsonStringEnumMemberName("Em Aberto")]
    EmAberto,
    [JsonStringEnumMemberName("Baixado")]
    Baixado,
    [JsonStringEnumMemberName("Liquidado")]
    Liquidado,
}
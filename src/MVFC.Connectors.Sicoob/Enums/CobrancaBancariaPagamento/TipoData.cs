namespace MVFC.Connectors.Sicoob.Enums.CobrancaBancariaPagamento;

[JsonConverter(typeof(SafeEnumConverter<TipoData>))]
public enum TipoData
{
    [JsonStringEnumMemberName("Desconhecido")]
    Desconhecido = 0,
    [JsonStringEnumMemberName("Data de vencimento")]
    DataVencimento = 1,
    [JsonStringEnumMemberName("Data de emissão")]
    DataEmissao = 2,
    [JsonStringEnumMemberName("Data de inclusão")]
    DataInclusao = 3,
}
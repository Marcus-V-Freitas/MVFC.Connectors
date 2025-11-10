namespace MVFC.Connectors.BrasilApi.CNPJ.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum MatrizFilial
{
    [JsonStringEnumMemberName("MATRIZ")]
    Matriz = 1,
    [JsonStringEnumMemberName("FILIAL")]
    Filial = 2,
}

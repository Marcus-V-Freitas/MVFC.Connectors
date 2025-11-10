namespace MVFC.Connectors.BrasilApi.CNPJ.Enums;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum IdentificadorSocio
{
    [JsonStringEnumMemberName("PESSOA JURÍDICA")]
    PessoaJuridica = 1,
    [JsonStringEnumMemberName("PESSOA FÍSICA")]
    PessoaFisica = 2,
    [JsonStringEnumMemberName("ESTRANGEIRO")]
    Estrangeiro = 3
}

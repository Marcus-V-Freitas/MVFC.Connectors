namespace MVFC.Connectors.BrasilApi.CNPJ.Modelos.Dtos;

public record RegimeTributarioDto(
    [property: JsonPropertyName("ano")] int Ano,
    [property: JsonPropertyName("cnpj_da_scp")] string? CnpjDaScp,
    [property: JsonPropertyName("forma_de_tributacao")] string FormaDeTributacao,
    [property: JsonPropertyName("quantidade_de_escrituracoes")] int QuantidadeDeEscrituracoes);
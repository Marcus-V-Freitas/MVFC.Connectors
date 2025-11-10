namespace MVFC.Connectors.BrasilApi.Corretoras.Modelos.Dtos;

public sealed record CorretoraDto(
    [property: JsonPropertyName("bairro")] string Bairro,
    [property: JsonPropertyName("cep")] string Cep,
    [property: JsonPropertyName("cnpj")] string Cnpj,
    [property: JsonPropertyName("codigo_cvm")] string CodigoCvm,
    [property: JsonPropertyName("complemento")] string Complemento,
    [property: JsonPropertyName("data_inicio_situacao")] string DataInicioSituacao,
    [property: JsonPropertyName("data_patrimonio_liquido")] string DataPatrimonioLiquido,
    [property: JsonPropertyName("data_registro")] string DataRegistro,
    [property: JsonPropertyName("email")] string Email,
    [property: JsonPropertyName("logradouro")] string Logradouro,
    [property: JsonPropertyName("municipio")] string Municipio,
    [property: JsonPropertyName("nome_social")] string NomeSocial,
    [property: JsonPropertyName("nome_comercial")] string NomeComercial,
    [property: JsonPropertyName("pais")] string Pais,
    [property: JsonPropertyName("status")] string Status,
    [property: JsonPropertyName("telefone")] string Telefone,
    [property: JsonPropertyName("type")] string Type,
    [property: JsonPropertyName("uf")] string Uf,
    [property: JsonPropertyName("valor_patrimonio_liquido")] string ValorPatrimonioLiquido);
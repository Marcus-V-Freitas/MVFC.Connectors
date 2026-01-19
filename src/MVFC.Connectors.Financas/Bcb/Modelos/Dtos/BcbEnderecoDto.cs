namespace MVFC.Connectors.Financas.Bcb.Modelos.Dtos;

public sealed record BcbEnderecoDto(
        [property: JsonPropertyName("id")] int Id,
        [property: JsonPropertyName("logradouro")] string Logradouro,
        [property: JsonPropertyName("complemento")] string Complemento,
        [property: JsonPropertyName("bairro")] string Bairro,
        [property: JsonPropertyName("municipio")] BcbMunicipioDto Municipio,
        [property: JsonPropertyName("cep")] string Cep,
        [property: JsonPropertyName("enderecoEletronico")] string EnderecoEletronico,
        [property: JsonPropertyName("email")] string Email);
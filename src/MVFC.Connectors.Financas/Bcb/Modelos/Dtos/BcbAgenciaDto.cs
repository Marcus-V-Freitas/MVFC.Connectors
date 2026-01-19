namespace MVFC.Connectors.Financas.Bcb.Modelos.Dtos;

public sealed record BcbAgenciaDto(
        [property: JsonPropertyName("id")] int Id,
        [property: JsonPropertyName("compe")] string Compe,
        [property: JsonPropertyName("nome")] string Nome,
        [property: JsonPropertyName("endereco")] BcbEnderecoDto Endereco,
        [property: JsonPropertyName("ddd")] string Ddd,
        [property: JsonPropertyName("numeroTelefone")] string NumeroTelefone);
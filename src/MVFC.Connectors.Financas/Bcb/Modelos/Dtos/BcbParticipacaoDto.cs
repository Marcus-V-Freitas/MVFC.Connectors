namespace MVFC.Connectors.Financas.Bcb.Modelos.Dtos;

public sealed record BcbParticipacaoDto(
        [property: JsonPropertyName("id")] int Id,
        [property: JsonPropertyName("cnpj")] string Cnpj,
        [property: JsonPropertyName("idBacen")] string IdBacen,
        [property: JsonPropertyName("condicao")] string Condicao,
        [property: JsonPropertyName("nome")] string Nome,
        [property: JsonPropertyName("temCadastro")] bool TemCadastro);
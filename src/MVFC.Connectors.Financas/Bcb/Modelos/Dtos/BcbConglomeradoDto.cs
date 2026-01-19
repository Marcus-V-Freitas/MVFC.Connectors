namespace MVFC.Connectors.Financas.Bcb.Modelos.Dtos;

public sealed record BcbConglomeradoDto(
        [property: JsonPropertyName("id")] int? Id,
        [property: JsonPropertyName("codigo")] int Codigo,
        [property: JsonPropertyName("nome")] string Nome,
        [property: JsonPropertyName("tipo")] string Tipo,
        [property: JsonPropertyName("participacoes")] IReadOnlyList<BcbParticipacaoDto> Participacoes);
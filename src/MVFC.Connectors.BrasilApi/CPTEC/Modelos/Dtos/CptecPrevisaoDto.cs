namespace MVFC.Connectors.BrasilApi.CPTEC.Modelos.Dtos;

public sealed record CptecPrevisaoDto<T>(
    [property: JsonPropertyName("cidade")] string Cidade,
    [property: JsonPropertyName("estado")] string Estado,
    [property: JsonPropertyName("atualizado_em")] string AtualizadoEm,
    [property: JsonPropertyName("clima")] IReadOnlyList<T> Clima);
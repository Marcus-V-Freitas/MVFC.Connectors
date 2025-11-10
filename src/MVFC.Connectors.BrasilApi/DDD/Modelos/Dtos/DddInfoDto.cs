namespace MVFC.Connectors.BrasilApi.DDD.Modelos.Dtos;

public sealed record DddInfoDto(
    [property: JsonPropertyName("state")] string State,
    [property: JsonPropertyName("cities")] IReadOnlyList<string> Cities);
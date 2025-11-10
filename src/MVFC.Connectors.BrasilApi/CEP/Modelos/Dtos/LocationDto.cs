namespace MVFC.Connectors.BrasilApi.CEP.Modelos.Dtos;

public sealed record class LocationDto(
    [property: JsonPropertyName("type")] string Type,
    [property: JsonPropertyName("coordinates")] CoordinatesDto Coordinates);
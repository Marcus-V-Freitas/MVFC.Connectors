namespace MVFC.Connectors.BrasilApi.CEP.Modelos.Dtos;

public sealed record class CoordinatesDto(
    [property: JsonPropertyName("longitude")] string Longitude,
    [property: JsonPropertyName("latitude")] string Latitude);
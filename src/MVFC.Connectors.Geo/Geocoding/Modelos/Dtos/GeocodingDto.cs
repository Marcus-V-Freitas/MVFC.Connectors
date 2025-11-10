namespace MVFC.Connectors.Geo.Geocoding.Modelos.Dtos;

public sealed record GeocodingDto(
    [property: JsonPropertyName("results")] IReadOnlyList<GeocodingResultDto> Results,
    [property: JsonPropertyName("generationtime_ms")] double? GenerationtimeMs);
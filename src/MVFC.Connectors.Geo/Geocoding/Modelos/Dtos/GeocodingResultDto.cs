namespace MVFC.Connectors.Geo.Geocoding.Modelos.Dtos;

public sealed record GeocodingResultDto(
    [property: JsonPropertyName("id")] int Id,
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("latitude")] double? Latitude,
    [property: JsonPropertyName("longitude")] double? Longitude,
    [property: JsonPropertyName("elevation")] double? Elevation,
    [property: JsonPropertyName("feature_code")] string FeatureCode,
    [property: JsonPropertyName("country_code")] string CountryCode,
    [property: JsonPropertyName("admin1_id")] int? Admin1Id,
    [property: JsonPropertyName("timezone")] string Timezone,
    [property: JsonPropertyName("population")] int? Population,
    [property: JsonPropertyName("postcodes")] IReadOnlyList<string> Postcodes,
    [property: JsonPropertyName("country_id")] int? CountryId,
    [property: JsonPropertyName("country")] string Country,
    [property: JsonPropertyName("admin1")] string Admin1,
    [property: JsonPropertyName("admin2_id")] int? Admin2Id,
    [property: JsonPropertyName("admin2")] string Admin2,
    [property: JsonPropertyName("admin3_id")] int? Admin3Id,
    [property: JsonPropertyName("admin3")] string Admin3);

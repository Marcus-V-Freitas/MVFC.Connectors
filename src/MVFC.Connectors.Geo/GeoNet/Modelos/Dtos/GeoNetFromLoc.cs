namespace MVFC.Connectors.Geo.GeoNet.Modelos.Dtos;

public sealed record GeoNetFromLoc(
        [property: JsonPropertyName("city")] string City,
        [property: JsonPropertyName("country")] string Country,
        [property: JsonPropertyName("latlon")] string Latlon);
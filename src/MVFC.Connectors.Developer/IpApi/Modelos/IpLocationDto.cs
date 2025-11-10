namespace MVFC.Connectors.Developer.IpApi.Modelos;

public sealed record IpLocationDto(
    [property: JsonPropertyName("is_eu_member")] bool IsEuMember,
    [property: JsonPropertyName("calling_code")] string CallingCode,
    [property: JsonPropertyName("currency_code")] string CurrencyCode,
    [property: JsonPropertyName("continent")] string Continent,
    [property: JsonPropertyName("country")] string Country,
    [property: JsonPropertyName("country_code")] string CountryCode,
    [property: JsonPropertyName("state")] string State,
    [property: JsonPropertyName("city")] string City,
    [property: JsonPropertyName("latitude")] double Latitude,
    [property: JsonPropertyName("longitude")] double Longitude,
    [property: JsonPropertyName("zip")] string Zip,
    [property: JsonPropertyName("timezone")] string Timezone,
    [property: JsonPropertyName("local_time")] DateTime LocalTime,
    [property: JsonPropertyName("local_time_unix")] int LocalTimeUnix,
    [property: JsonPropertyName("is_dst")] bool IsDst);
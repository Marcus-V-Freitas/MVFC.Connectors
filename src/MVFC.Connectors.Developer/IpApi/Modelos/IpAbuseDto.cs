namespace MVFC.Connectors.Developer.IpApi.Modelos;

public sealed record IpAbuseDto(
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("address")] string Address,
    [property: JsonPropertyName("email")] string Email,
    [property: JsonPropertyName("phone")] string Phone);
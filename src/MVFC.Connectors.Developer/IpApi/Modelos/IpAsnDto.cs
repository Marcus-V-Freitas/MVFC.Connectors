namespace MVFC.Connectors.Developer.IpApi.Modelos;

public sealed record IpAsnDto(
    [property: JsonPropertyName("asn")] int Asn,
    [property: JsonPropertyName("abuser_score")] string AbuserScore,
    [property: JsonPropertyName("route")] string Route,
    [property: JsonPropertyName("descr")] string Descr,
    [property: JsonPropertyName("country")] string Country,
    [property: JsonPropertyName("active")] bool Active,
    [property: JsonPropertyName("org")] string Org,
    [property: JsonPropertyName("domain")] string Domain,
    [property: JsonPropertyName("abuse")] string Abuse,
    [property: JsonPropertyName("type")] string Type,
    [property: JsonPropertyName("created")] string Created,
    [property: JsonPropertyName("updated")] string Updated,
    [property: JsonPropertyName("rir")] string Rir,
    [property: JsonPropertyName("whois")] string Whois);
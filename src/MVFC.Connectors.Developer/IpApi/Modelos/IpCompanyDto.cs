namespace MVFC.Connectors.Developer.IpApi.Modelos;

public sealed record IpCompanyDto(
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("abuser_score")] string AbuserScore,
    [property: JsonPropertyName("domain")] string Domain,
    [property: JsonPropertyName("type")] string Type,
    [property: JsonPropertyName("network")] string Network,
    [property: JsonPropertyName("whois")] string Whois);
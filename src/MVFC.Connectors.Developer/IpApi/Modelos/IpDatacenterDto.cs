namespace MVFC.Connectors.Developer.IpApi.Modelos;

public sealed record IpDatacenterDto(
    [property: JsonPropertyName("datacenter")] string Datacenter,
    [property: JsonPropertyName("network")] string Network,
    [property: JsonPropertyName("country")] string Country,
    [property: JsonPropertyName("region")] string Region,
    [property: JsonPropertyName("city")] string City);
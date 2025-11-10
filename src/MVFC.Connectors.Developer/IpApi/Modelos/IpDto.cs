namespace MVFC.Connectors.Developer.IpApi.Modelos;

public sealed record IpDto(
    [property: JsonPropertyName("ip")] string Ip,
    [property: JsonPropertyName("rir")] string Rir,
    [property: JsonPropertyName("is_bogon")] bool IsBogon,
    [property: JsonPropertyName("is_mobile")] bool IsMobile,
    [property: JsonPropertyName("is_satellite")] bool IsSatellite,
    [property: JsonPropertyName("is_crawler")] bool IsCrawler,
    [property: JsonPropertyName("is_datacenter")] bool IsDatacenter,
    [property: JsonPropertyName("is_tor")] bool IsTor,
    [property: JsonPropertyName("is_proxy")] bool IsProxy,
    [property: JsonPropertyName("is_vpn")] bool IsVpn,
    [property: JsonPropertyName("is_abuser")] bool IsAbuser,
    [property: JsonPropertyName("datacenter")] IpDatacenterDto Datacenter,
    [property: JsonPropertyName("company")] IpCompanyDto Company,
    [property: JsonPropertyName("abuse")] IpAbuseDto Abuse,
    [property: JsonPropertyName("asn")] IpAsnDto Asn,
    [property: JsonPropertyName("location")] IpLocationDto Location,
    [property: JsonPropertyName("elapsed_ms")] double ElapsedMs);
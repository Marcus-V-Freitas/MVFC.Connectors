namespace MVFC.Connectors.BrasilApi.RegistroBR.Modelos.Dtos;

public sealed record RegistroBrDto(
    [property: JsonPropertyName("status_code")] int StatusCode,
    [property: JsonPropertyName("status")] string Status,
    [property: JsonPropertyName("fqdn")] string Fqdn,
    [property: JsonPropertyName("fqdnace")] string Fqdnace,
    [property: JsonPropertyName("exempt")] bool Exempt,
    [property: JsonPropertyName("hosts")] IReadOnlyList<string> Hosts,
    [property: JsonPropertyName("publication-status")] string PublicationStatus,
    [property: JsonPropertyName("expires-at")] DateTime ExpiresAt,
    [property: JsonPropertyName("suggestions")] IReadOnlyList<string> Suggestions);
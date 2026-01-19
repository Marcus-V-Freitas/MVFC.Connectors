namespace MVFC.Connectors.Educacao.Hipolabs.Modelos;

public sealed record HipolabsDto(
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("country")] string Country,
    [property: JsonPropertyName("web_pages")] IReadOnlyList<string> WebPages,
    [property: JsonPropertyName("alpha_two_code")] string AlphaTwoCode,
    [property: JsonPropertyName("state-province")] string StateProvince,
    [property: JsonPropertyName("domains")] IReadOnlyList<string> Domains);
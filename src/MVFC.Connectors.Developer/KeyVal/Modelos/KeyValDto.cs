namespace MVFC.Connectors.Developer.KeyVal.Modelos;

public sealed record KeyValDto(
    [property: JsonPropertyName("status")] string Status,
    [property: JsonPropertyName("key")] string Key,
    [property: JsonPropertyName("val")] string Val);

namespace MVFC.Connectors.Conversores.DictionaryApi.Modelos.Dtos;

public sealed record DictPhoneticDto(
        [property: JsonPropertyName("text")] string Text,
        [property: JsonPropertyName("audio")] string Audio,
        [property: JsonPropertyName("sourceUrl")] string SourceUrl,
        [property: JsonPropertyName("license")] DictLicenseDto License);

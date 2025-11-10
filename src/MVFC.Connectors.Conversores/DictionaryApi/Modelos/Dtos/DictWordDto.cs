namespace MVFC.Connectors.Conversores.DictionaryApi.Modelos.Dtos;

public sealed record DictWordDto(
        [property: JsonPropertyName("word")] string Word,
        [property: JsonPropertyName("phonetic")] string Phonetic,
        [property: JsonPropertyName("phonetics")] IReadOnlyList<DictPhoneticDto> Phonetics,
        [property: JsonPropertyName("meanings")] IReadOnlyList<DictMeaningDto> Meanings,
        [property: JsonPropertyName("license")] DictLicenseDto License,
        [property: JsonPropertyName("sourceUrls")] IReadOnlyList<string> SourceUrls);
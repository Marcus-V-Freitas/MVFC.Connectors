namespace MVFC.Connectors.Conversores.DictionaryApi.Modelos.Dtos;

public sealed record DictMeaningDto(
        [property: JsonPropertyName("partOfSpeech")] string PartOfSpeech,
        [property: JsonPropertyName("definitions")] IReadOnlyList<DictDefinitionDto> Definitions,
        [property: JsonPropertyName("synonyms")] IReadOnlyList<object> Synonyms,
        [property: JsonPropertyName("antonyms")] IReadOnlyList<object> Antonyms);
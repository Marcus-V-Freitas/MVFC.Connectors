namespace MVFC.Connectors.Conversores.DictionaryApi.Modelos.Dtos;

public sealed record DictDefinitionDto(
        [property: JsonPropertyName("definition")] string Definition,
        [property: JsonPropertyName("synonyms")] IReadOnlyList<object> Synonyms,
        [property: JsonPropertyName("antonyms")] IReadOnlyList<object> Antonyms,
        [property: JsonPropertyName("example")] string Example);
namespace MVFC.Connectors.Conversores.DictionaryApi.Modelos.Dtos;
public sealed record DictLicenseDto(
        [property: JsonPropertyName("name")] string Name,
        [property: JsonPropertyName("url")] string Url);
namespace MVFC.Connectors.BrasilApi.ISBN.Modelos.Dtos;

public sealed record IsbnDimensaoDto(
    [property: JsonPropertyName("width")] double Width,
    [property: JsonPropertyName("height")] double Height,
    [property: JsonPropertyName("unit")] string Unit);
namespace MVFC.Connectors.BrasilApi.ISBN.Modelos.Dtos;

public sealed record IsbnLivroDto(
    [property: JsonPropertyName("isbn")] string Isbn,
    [property: JsonPropertyName("title")] string Title,
    [property: JsonPropertyName("subtitle")] string Subtitle,
    [property: JsonPropertyName("authors")] IReadOnlyList<string> Authors,
    [property: JsonPropertyName("publisher")] string Publisher,
    [property: JsonPropertyName("synopsis")] string Synopsis,
    [property: JsonPropertyName("dimensions")] IsbnDimensaoDto Dimensions,
    [property: JsonPropertyName("year")] int Year,
    [property: JsonPropertyName("format")] string Format,
    [property: JsonPropertyName("page_count")] int PageCount,
    [property: JsonPropertyName("subjects")] IReadOnlyList<string> Subjects,
    [property: JsonPropertyName("location")] string Location,
    [property: JsonPropertyName("retail_price")] double? RetailPrice,
    [property: JsonPropertyName("cover_url")] string CoverUrl,
    [property: JsonPropertyName("provider")] string Provider);
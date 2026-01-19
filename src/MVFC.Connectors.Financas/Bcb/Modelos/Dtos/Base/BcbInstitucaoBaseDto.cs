namespace MVFC.Connectors.Financas.Bcb.Modelos.Dtos.Base;

public abstract record BcbInstitucaoBaseDto<T>(
        [property: JsonPropertyName("content")] IReadOnlyList<T> Content,
        [property: JsonPropertyName("totalPages")] int TotalPages,
        [property: JsonPropertyName("totalElements")] int TotalElements,
        [property: JsonPropertyName("last")] bool Last,
        [property: JsonPropertyName("number")] int Number,
        [property: JsonPropertyName("size")] int Size,
        [property: JsonPropertyName("numberOfElements")] int NumberOfElements,
        [property: JsonPropertyName("sort")] object Sort,
        [property: JsonPropertyName("first")] bool First);
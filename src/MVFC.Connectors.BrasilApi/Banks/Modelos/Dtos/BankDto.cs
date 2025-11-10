namespace MVFC.Connectors.BrasilApi.Banks.Modelos.Dtos;

public sealed record BankDto(
    [property: JsonPropertyName("ispb")] string Ispb,
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("code")] int? Code,
    [property: JsonPropertyName("fullName")] string FullName);
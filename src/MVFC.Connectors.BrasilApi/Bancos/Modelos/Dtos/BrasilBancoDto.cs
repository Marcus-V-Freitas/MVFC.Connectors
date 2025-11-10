namespace MVFC.Connectors.BrasilApi.Bancos.Modelos.Dtos;

public sealed record BrasilBancoDto(
    [property: JsonPropertyName("ispb")] string Ispb,
    [property: JsonPropertyName("name")] string Name,
    [property: JsonPropertyName("code")] int? Code,
    [property: JsonPropertyName("fullName")] string FullName);
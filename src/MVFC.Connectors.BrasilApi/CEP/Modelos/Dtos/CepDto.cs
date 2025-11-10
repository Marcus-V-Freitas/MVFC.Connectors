namespace MVFC.Connectors.BrasilApi.CEP.Modelos.Dtos;

public sealed record class CepDto(
    [property: JsonPropertyName("cep")] string Cep,
    [property: JsonPropertyName("state")] string State,
    [property: JsonPropertyName("city")] string City,
    [property: JsonPropertyName("neighborhood")] string Neighborhood,
    [property: JsonPropertyName("street")] string Street,
    [property: JsonPropertyName("service")] string Service,
    [property: JsonPropertyName("location")] LocationDto Location);
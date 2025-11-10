namespace MVFC.Connectors.Developer.DisifyEmail.Modelos.Dtos;

public sealed record DisifyEmailDto(
        [property: JsonPropertyName("format")] bool Format,
        [property: JsonPropertyName("domain")] string Domain,
        [property: JsonPropertyName("disposable")] bool Disposable,
        [property: JsonPropertyName("dns")] bool Dns);
namespace MVFC.Connectors.Sicoob.Modelos.Response;

internal sealed record SicoobTokenResponse(
    [property: JsonPropertyName("access_token")] string AccessToken,
    [property: JsonPropertyName("expires_in")] int ExpiresIn);

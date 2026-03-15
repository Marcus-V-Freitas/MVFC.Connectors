namespace MVFC.Connectors.Sicoob.Providers;

internal sealed class SicoobAuthProvider(SicoobConfig config) : ITokenProvider
{
    private static readonly string _tokenUrl = "https://auth.sicoob.com.br/auth/realms/cooperado/protocol/openid-connect/token";
    private static readonly HttpClient _httpClient = new();
    private const int ExpiryBufferSeconds = 30;

    private string? _cachedToken;
    private DateTime _tokenExpiry = DateTime.MinValue;
    private readonly SemaphoreSlim _semaphore = new(1, 1);

    public async Task<string> ObterTokenAsync(CancellationToken cancellationToken)
    {
        if (!string.IsNullOrEmpty(_cachedToken) && DateTime.UtcNow < _tokenExpiry)
            return _cachedToken;

        await _semaphore.WaitAsync(cancellationToken).ConfigureAwait(false);
        try
        {
            if (!string.IsNullOrEmpty(_cachedToken) && DateTime.UtcNow < _tokenExpiry)
                return _cachedToken;

            var formData = new FormUrlEncodedContent(
            [
                new KeyValuePair<string, string>("grant_type", "client_credentials"),
                new KeyValuePair<string, string>("client_id", config.ClientId),
                new KeyValuePair<string, string>("client_secret", config.ClientSecret),
            ]);

            var response = await _httpClient.PostAsync(_tokenUrl, formData, cancellationToken).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
            var tokenResponse = JsonSerializer.Deserialize<SicoobTokenResponse>(content)
                ?? throw new InvalidOperationException("Failed to deserialize Sicoob token response.");

            _cachedToken = tokenResponse.AccessToken;
            _tokenExpiry = DateTime.UtcNow.AddSeconds(tokenResponse.ExpiresIn - ExpiryBufferSeconds);

            return _cachedToken;
        }
        finally
        {
            _semaphore.Release();
        }
    }

    public IDictionary<string, string> ObterAuthHeaders() =>
        new Dictionary<string, string>()
        {
            { "client_id", config.ClientId },
        };
}

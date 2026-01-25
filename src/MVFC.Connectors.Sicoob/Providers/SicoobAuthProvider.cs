namespace MVFC.Connectors.Sicoob.Providers;

internal sealed class SicoobAuthProvider(SicoobConfig config) : ITokenProvider
{
    public async Task<string> ObterTokenAsync(CancellationToken cancellationToken) =>
        await Task.FromResult(config.AccessToken);

    public IDictionary<string, string> ObterAuthHeaders() =>
        new Dictionary<string, string>()
        {
            { "client_id", config.ClientId },
        };
}
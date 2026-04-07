namespace MVFC.Connectors.IA.Pollinations.Providers;

internal sealed class IImagemPollinationsProvider : ITokenProvider
{
    public async Task<string> ObterTokenAsync(CancellationToken cancellationToken) =>
        await Task.FromResult("pk_iOJLArs0DLNG7EGm").ConfigureAwait(false);

    public IDictionary<string, string> ObterAuthHeaders() => 
        new Dictionary<string, string>();
}

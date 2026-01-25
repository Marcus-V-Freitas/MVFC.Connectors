namespace MVFC.Connectors.Justica.DataJud.Providers;

internal sealed class DataJudAuthProvider : ITokenProvider
{
    public string TipoDeToken => "APIKey";
    
    public async Task<string> ObterTokenAsync(CancellationToken cancellationToken) =>
        await Task.FromResult("cDZHYzlZa0JadVREZDJCendQbXY6SkJlTzNjLV9TRENyQk1RdnFKZGRQdw==");

    public IDictionary<string, string> ObterAuthHeaders() => 
        new Dictionary<string, string>();
}
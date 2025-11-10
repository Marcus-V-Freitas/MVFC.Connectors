
namespace MVFC.Connectors.Justica.DataJud.Providers;

internal sealed class DataJudAuthProvider : ITokenProvider
{
    public string TokenType => "APIKey";

    public async Task<string> GetTokenAsync(CancellationToken cancellationToken) =>
        await Task.FromResult("cDZHYzlZa0JadVREZDJCendQbXY6SkJlTzNjLV9TRENyQk1RdnFKZGRQdw==");
}
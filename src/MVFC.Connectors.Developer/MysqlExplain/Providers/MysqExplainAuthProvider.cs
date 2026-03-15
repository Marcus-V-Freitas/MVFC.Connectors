namespace MVFC.Connectors.Developer.MysqlExplain.Providers;

internal sealed class MysqExplainAuthProvider : ITokenProvider
{
    public async Task<string> ObterTokenAsync(CancellationToken cancellationToken) =>
        await Task.FromResult(string.Empty).ConfigureAwait(false);

    public IDictionary<string, string> ObterAuthHeaders() =>
        new Dictionary<string, string>()
        {
            { "X-CSRF-TOKEN", GenerateCsrfToken() },
        };

    private static string GenerateCsrfToken(int size = 32)
    {
        var bytes = RandomNumberGenerator.GetBytes(size);
        return Convert.ToHexString(bytes);
    }
}

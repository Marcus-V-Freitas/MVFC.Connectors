namespace MVFC.Connectors.Commons.Handlers;

public sealed class AuthTokenHandler(ITokenProvider tokenProvider) : DelegatingHandler
{
    private readonly ITokenProvider _tokenProvider = tokenProvider;

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        var token = await _tokenProvider.ObterTokenAsync(cancellationToken);

        if (!string.IsNullOrEmpty(token))
        {
            request.Headers.Authorization = new AuthenticationHeaderValue(_tokenProvider.TipoDeToken, token);
        }

        foreach (var header in _tokenProvider.ObterAuthHeaders())
        {
            request.Headers.TryAddWithoutValidation(header.Key, header.Value);
        }

        return await base.SendAsync(request, cancellationToken);
    }
}
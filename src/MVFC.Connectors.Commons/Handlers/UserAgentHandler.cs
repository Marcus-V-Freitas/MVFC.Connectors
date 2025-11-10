namespace MVFC.Connectors.Commons.Handlers;

internal sealed class UserAgentHandler(IUserAgentProvider userAgentProvider) : DelegatingHandler
{
    private readonly IUserAgentProvider _userAgentProvider = userAgentProvider;

    protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        var userAgent = _userAgentProvider.ObterUserAgent();

        if (!string.IsNullOrWhiteSpace(userAgent))
        {
            request.Headers.UserAgent.Clear();
            request.Headers.UserAgent.TryParseAdd(userAgent);
        }

        return base.SendAsync(request, cancellationToken);
    }
}
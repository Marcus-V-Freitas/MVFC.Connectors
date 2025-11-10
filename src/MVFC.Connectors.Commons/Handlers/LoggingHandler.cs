namespace MVFC.Connectors.Commons.Handlers;

internal sealed class LoggingHandler(ILogger<LoggingHandler> logger) : DelegatingHandler
{
    private readonly ILogger<LoggingHandler> _logger = logger;

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        _logger.LogRequest(request.Method.Method, request.RequestUri);

        var response = await base.SendAsync(request, cancellationToken);

        _logger.LogResponse(response.StatusCode);

        return response;
    }
}
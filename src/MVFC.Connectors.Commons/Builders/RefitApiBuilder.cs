namespace MVFC.Connectors.Commons.Builders;

public sealed class RefitApiBuilder<T>
    where T : IConnectorApi
{
    private readonly string _baseUrl;
    private readonly IList<DelegatingHandler> _handlers = [];
    private RefitSettings? _refitSettings;
    private HttpSettings? _httpSettings;

    private RefitApiBuilder(string baseUrl)
    {
        _baseUrl = baseUrl;
    }

    public static RefitApiBuilder<T> Criar(string baseUrl) => new(baseUrl);

    public RefitApiBuilder<T> AdicionarHandler(DelegatingHandler handler)
    {
        _handlers.Add(handler);
        return this;
    }

    public RefitApiBuilder<T> AdicionarHandler<THandler>() where THandler : DelegatingHandler, new()
    {
        _handlers.Add(new THandler());
        return this;
    }

    internal RefitApiBuilder<T> AdicionarLogging(ILogger<LoggingHandler> logger)
    {
        _handlers.Add(new LoggingHandler(logger));
        return this;
    }

    public RefitApiBuilder<T> AdicionarUserAgent(IUserAgentProvider provider)
    {
        _handlers.Add(new UserAgentHandler(provider));
        return this;
    }

    public RefitApiBuilder<T> AdicionarRefitSettings(RefitSettings? settings)
    {
        _refitSettings = settings;
        return this;
    }

    public RefitApiBuilder<T> AdicionarHttpSettings(HttpSettings? settings)
    {
        _httpSettings = settings;
        return this;
    }


    public T Construir()
    {
        _handlers.Add(ExtensoesResilience.CriarStandardResilienceHandler(_httpSettings ?? new HttpSettings()));

        HttpMessageHandler innerHandler = new HttpClientHandler()
        {
            ServerCertificateCustomValidationCallback = (_, _, _, _) => true,
        };

        for (var i = _handlers.Count - 1; i >= 0; i--)
        {
            _handlers[i].InnerHandler = innerHandler;
            innerHandler = _handlers[i];
        }

        var httpClient = new HttpClient(innerHandler)
        {
            BaseAddress = new Uri(_baseUrl),
        };

        return RestService.For<T>(httpClient, _refitSettings);
    }
}
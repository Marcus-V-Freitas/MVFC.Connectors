namespace MVFC.Connectors.Commons.Extensoes;

public static class ExtensoesBase
{
    public static RefitApiBuilder<T> ObterApi<T>(string url, ConnectorsSettings? settings = null)
        where T : IConnectorApi
    {
        settings ??= new ConnectorsSettings();

        return RefitApiBuilder<T>
                         .Criar(url)
                         .AdicionarLogging(CriarLogging(settings.LogLevel))
                         .AdicionarUserAgent(new RandomUserAgentProvider())
                         .AdicionarHttpSettings(settings.HttpSettings)
                         .AdicionarRefitSettings(settings.RefitSettings);
    }

    public static IHttpClientBuilder AddApi<T>(this IServiceCollection services, string url, Action<ConnectorsSettingsServices, IServiceCollection>? action = null)
        where T : class, IConnectorApi
    {
        services.AddSingleton<IUserAgentProvider, RandomUserAgentProvider>();
        services.AddTransient<LoggingHandler>();
        services.AddTransient<UserAgentHandler>();

        var settings = new ConnectorsSettingsServices();
        action?.Invoke(settings, services);

        var http = services.AddRefitClient<T>(settings.RefitSettings)
                           .ConfigureHttpClient(h => h.BaseAddress = new Uri(url))
                           .ConfigurePrimaryHttpMessageHandler(() => new HttpClientHandler 
                           { 
                               ServerCertificateCustomValidationCallback = (_, _, _, _) => true,
                           })
                           .AddHttpMessageHandler<LoggingHandler>()
                           .AddHttpMessageHandler<UserAgentHandler>()
                           .AdicionarResiliencia(settings.HttpAction);

        http.AddStandardResilienceHandler();

        return http;
    }

    private static ILogger<LoggingHandler> CriarLogging(LogLevel logLevel)
    {
        var loggerFactory = LoggerFactory.Create(builder =>
        {
            builder.AddConsole();
            builder.SetMinimumLevel(logLevel);
        });

        return loggerFactory.CreateLogger<LoggingHandler>();
    }
}
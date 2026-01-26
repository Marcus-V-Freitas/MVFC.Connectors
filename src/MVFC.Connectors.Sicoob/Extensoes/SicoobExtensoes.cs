namespace MVFC.Connectors.Sicoob.Extensoes;

internal static class SicoobExtensoes
{
    private static readonly SystemTextJsonContentSerializer _jsonOptions = new(new()
    {
        NumberHandling = JsonNumberHandling.AllowReadingFromString,
        PropertyNameCaseInsensitive = true,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,        
        WriteIndented = true,
    });

    internal static T ObterSicoobApi<T>(Dictionary<bool, string> urlsBase, SicoobConfig config)
        where T : IConnectorApi =>
         ExtensoesBase.ObterApi<T>(urlsBase[config.SandBox])
                      .AdicionarHandler(new AuthTokenHandler(new SicoobAuthProvider(config)))
                      .AdicionarRefitSettings(new RefitSettings
                      {
                          ContentSerializer = _jsonOptions,
                      })
                      .Construir();

    internal static void AddSicoob<T>(this IServiceCollection services, Dictionary<bool, string> urlsBase, SicoobConfig config)
        where T : class, IConnectorApi =>
        services.AddApi<T>(urlsBase[config.SandBox], (c, s) =>
        {
            c.RefitSettings.ContentSerializer = _jsonOptions;
            s.TryAddSingleton(config);
            s.TryAddSingleton<ITokenProvider, SicoobAuthProvider>();
            s.TryAddTransient<AuthTokenHandler>();
        }).AddHttpMessageHandler<AuthTokenHandler>();
}
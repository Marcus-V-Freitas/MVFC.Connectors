namespace MVFC.Connectors.Sicoob.Extensoes;

public static class SicoobCobrancaBancariaExtensoes
{
    private static readonly Dictionary<bool, string> _urlsBase = new()
    {
        { false, "https://api.sicoob.com.br/cobranca-bancaria/v3" },
        { true,  "https://sandbox.sicoob.com.br/sicoob/sandbox/cobranca-bancaria/v3" }
    };

    private static readonly SystemTextJsonContentSerializer _jsonOptions = new(Options());

    private static JsonSerializerOptions Options()
    {
        var jsonOptions = new JsonSerializerOptions()
        {
            NumberHandling = JsonNumberHandling.AllowReadingFromString,
            PropertyNameCaseInsensitive = true,
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
            WriteIndented = true,
        };

        return jsonOptions;
    } 

    public static ISicoobCobrancaBancariaApi ObterSicoobCobrancaBancariaApi(SicoobConfig config) =>
         ExtensoesBase.ObterApi<ISicoobCobrancaBancariaApi>(_urlsBase[config.SandBox])
                      .AdicionarHandler(new AuthTokenHandler(new SicoobAuthProvider(config)))
                      .AdicionarRefitSettings(new RefitSettings
                      {
                          ContentSerializer = _jsonOptions,
                      })
                      .Construir();

    public static void AddSicoobCobrancaBancaria(this IServiceCollection services, SicoobConfig config) =>
        services.AddApi<ISicoobCobrancaBancariaApi>(_urlsBase[config.SandBox], (c, s) =>
        {
            c.RefitSettings.ContentSerializer = _jsonOptions;
            s.TryAddSingleton(config);
            s.TryAddSingleton<ITokenProvider, SicoobAuthProvider>();
            s.TryAddTransient<AuthTokenHandler>();
        }).AddHttpMessageHandler<AuthTokenHandler>();
}
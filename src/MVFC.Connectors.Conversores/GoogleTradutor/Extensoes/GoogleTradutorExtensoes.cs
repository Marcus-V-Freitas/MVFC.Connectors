namespace MVFC.Connectors.Conversores.GoogleTradutor.Extensoes;

public static class GoogleTradutorExtensoes
{
    private const string URL_BASE = "https://translate.googleapis.com";

    public static IGoogleTradutorApi ObterGoogleTradutorApi() =>
         ExtensoesBase.ObterApi<IGoogleTradutorApi>(URL_BASE)
                      .AdicionarHandler(new GoogleTradutorHandler())
                      .Construir();

    public static void AddGoogleTradutor(this IServiceCollection services) =>
        services.AddApi<IGoogleTradutorApi>(URL_BASE, (_, s) => s.AddTransient<GoogleTradutorHandler>())
                .AddHttpMessageHandler<GoogleTradutorHandler>();
}

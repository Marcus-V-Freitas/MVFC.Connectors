namespace MVFC.Connectors.IA.Pollinations.Extensoes;

public static class ImagemPollinationExtensoes
{
    private const string URL_BASE = "https://gen.pollinations.ai/image";

    public static IImagemPollinationsApi ObterImagemPollinationsApi() =>
         ExtensoesBase.ObterApi<IImagemPollinationsApi>(URL_BASE)
                      .AdicionarHandler(new AuthTokenHandler(new IImagemPollinationsProvider()))
                      .Construir();

    public static void AddImagemPollinations(this IServiceCollection services) =>
        services.AddApi<IImagemPollinationsApi>(URL_BASE, (_, s) =>
        {
            s.TryAddSingleton<ITokenProvider, IImagemPollinationsProvider>();
            s.TryAddTransient<AuthTokenHandler>();
        }).AddHttpMessageHandler<AuthTokenHandler>();
}

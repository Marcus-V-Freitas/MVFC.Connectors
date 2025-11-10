namespace MVFC.Connectors.IA.Pollinations.Extensoes;

public static class ImagemPollinationExtensoes
{
    private const string URL_BASE = "https://image.pollinations.ai";

    public static IImagemPollinationsApi ObterImagemPollinationsApi() =>
         ExtensoesBase.ObterApi<IImagemPollinationsApi>(URL_BASE).Construir();

    public static void AddImagemPollinations(this IServiceCollection services) =>
        services.AddApi<IImagemPollinationsApi>(URL_BASE);
}
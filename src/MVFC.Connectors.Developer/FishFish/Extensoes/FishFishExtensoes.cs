namespace MVFC.Connectors.Developer.FishFish.Extensoes;

public static class FishFishExtensoes
{
    private const string URL_BASE = "https://api.fishfish.gg/v1";

    public static IFishFishApi ObterFishFishApi() =>
         ExtensoesBase.ObterApi<IFishFishApi>(URL_BASE).Construir();

    public static void AddFishFish(this IServiceCollection services) =>
        services.AddApi<IFishFishApi>(URL_BASE);
}
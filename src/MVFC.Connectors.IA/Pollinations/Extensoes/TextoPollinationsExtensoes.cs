namespace MVFC.Connectors.IA.Pollinations.Extensoes;

public static class TextoPollinationsExtensoes
{
    private const string URL_BASE = "https://text.pollinations.ai";

    public static ITextoPollinationsApi ObterTextoPollinationsApi() =>
         ExtensoesBase.ObterApi<ITextoPollinationsApi>(URL_BASE).Construir();

    public static void AddTextoPollinations(this IServiceCollection services) =>
        services.AddApi<ITextoPollinationsApi>(URL_BASE);
}
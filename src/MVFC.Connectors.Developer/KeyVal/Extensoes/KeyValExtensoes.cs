namespace MVFC.Connectors.Developer.KeyVal.Extensoes;

public static class KeyValExtensoes
{
    private const string URL_BASE = "https://api.keyval.org";

    public static IKeyValApi ObterKeyValApi() =>
         ExtensoesBase.ObterApi<IKeyValApi>(URL_BASE).Construir();

    public static void AddKeyVal(this IServiceCollection services) =>
        services.AddApi<IKeyValApi>(URL_BASE);
}
namespace MVFC.Connectors.Conversores.DictionaryApi.Modelos.Extensoes;

public static class DictionaryApiExtensoes
{
    private const string URL_BASE = "https://api.dictionaryapi.dev/api/v2";

    public static IDictionaryApi ObterDictionaryApi() =>
         ExtensoesBase.ObterApi<IDictionaryApi>(URL_BASE).Construir();

    public static void AddDictionaryApi(this IServiceCollection services) =>
        services.AddApi<IDictionaryApi>(URL_BASE);
}
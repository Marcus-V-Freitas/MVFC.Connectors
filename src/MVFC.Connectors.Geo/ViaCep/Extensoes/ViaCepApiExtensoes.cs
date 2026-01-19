namespace MVFC.Connectors.Geo.ViaCep.Extensoes;

public static class ViaCepApiExtensoes
{
    private const string URL_BASE = "https://viacep.com.br";

    public static IViaCepApi ObterViaCepApi() =>
         ExtensoesBase.ObterApi<IViaCepApi>(URL_BASE).Construir();

    public static void AddViaCep(this IServiceCollection services) =>
        services.AddApi<IViaCepApi>(URL_BASE);
}
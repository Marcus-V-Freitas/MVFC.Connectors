namespace MVFC.Connectors.Developer.DisifyEmail.Extensoes;

public static class DisifyEmailApiExtensoes
{
    private const string URL_BASE = "https://www.disify.com/api";

    public static IDisifyEmailApi ObterDisifyEmailApi() =>
         ExtensoesBase.ObterApi<IDisifyEmailApi>(URL_BASE).Construir();

    public static void AddDisifyEmail(this IServiceCollection services) =>
        services.AddApi<IDisifyEmailApi>(URL_BASE);
}
namespace MVFC.Connectors.BrasilApi.RegistroBR.Extensoes;

public static class RegistroBrBrasilApiExtensoes
{
    public static IRegistroBrApi ObterRegistroBrBrasilApi() =>
        BrasilExtensoes.ObterBrasilApi<IRegistroBrApi>();

    public static void AddRegistroBrBrasilApi(this IServiceCollection services) =>
        services.AddBrasilApi<IRegistroBrApi>();
}
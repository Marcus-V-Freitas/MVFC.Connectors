namespace MVFC.Connectors.BrasilApi.Fipe.Extensoes;

public static class FipeBrasilApiExtensoes
{
    public static IFipeBrasilApi ObterFipeBrasilApi() =>
        BrasilExtensoes.ObterBrasilApi<IFipeBrasilApi>();

    public static void AddFipeBrasilApi(this IServiceCollection services) =>
        services.AddBrasilApi<IFipeBrasilApi>();
}
namespace MVFC.Connectors.BrasilApi.IBGE.Extensoes;

public static class IbgeBrasilApiExtensoes
{
    public static IIbgeBrasilApi ObterIbgeBrasilApi() =>
        BrasilExtensoes.ObterBrasilApi<IIbgeBrasilApi>();

    public static void AddIbgeBrasilApi(this IServiceCollection services) =>
        services.AddBrasilApi<IIbgeBrasilApi>();
}
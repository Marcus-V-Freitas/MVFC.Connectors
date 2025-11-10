namespace MVFC.Connectors.BrasilApi.CPTEC.Extensoes;

public static class CptecBrasilApiExtensoes
{
    public static ICptecBrasilApi ObterCptecBrasilApi() =>
        BrasilExtensoes.ObterBrasilApi<ICptecBrasilApi>();

    public static void AddCptecBrasilApi(this IServiceCollection services) =>
        services.AddBrasilApi<ICptecBrasilApi>();
}
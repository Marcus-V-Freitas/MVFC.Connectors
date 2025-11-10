namespace MVFC.Connectors.BrasilApi.NCM.Extensoes;

public static class NcmBrasilApiExtensoes
{
    public static INcmBrasilApi ObterNcmBrasilApi() =>
        BrasilExtensoes.ObterBrasilApi<INcmBrasilApi>();

    public static void AddNcmBrasilApi(this IServiceCollection services) =>
        services.AddBrasilApi<INcmBrasilApi>();
}
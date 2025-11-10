namespace MVFC.Connectors.BrasilApi.CEP.Extensoes;

public static class CepBrasilApiExtensoes
{
    public static ICepBrasilApi ObterCepBrasilApi() =>
        BrasilExtensoes.ObterBrasilApi<ICepBrasilApi>();

    public static void AddCepBrasilApi(this IServiceCollection services) =>
        services.AddBrasilApi<ICepBrasilApi>();
}
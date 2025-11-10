namespace MVFC.Connectors.BrasilApi.Cambio.Extensoes;

public static class CambioBrasilApiExtensoes
{
    public static ICambioBrasilApi ObterCambioBrasilApi() =>
        BrasilExtensoes.ObterBrasilApi<ICambioBrasilApi>();

    public static void AddCambioBrasilApi(this IServiceCollection services) =>
        services.AddBrasilApi<ICambioBrasilApi>();
}
namespace MVFC.Connectors.BrasilApi.Feriados.Extensoes;

public static class FeriadoBrasilApiExtensoes
{
    public static IFeriadoBrasilApi ObterFeriadoBrasilApi() =>
        BrasilExtensoes.ObterBrasilApi<IFeriadoBrasilApi>();

    public static void AddFeriadoBrasilApi(this IServiceCollection services) =>
        services.AddBrasilApi<IFeriadoBrasilApi>();
}
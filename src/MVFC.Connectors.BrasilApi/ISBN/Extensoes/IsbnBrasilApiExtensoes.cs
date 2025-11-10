namespace MVFC.Connectors.BrasilApi.ISBN.Extensoes;

public static class IsbnBrasilApiExtensoes
{
    public static IIsbnBrasilApi ObterIsbnBrasilApi() =>
        BrasilExtensoes.ObterBrasilApi<IIsbnBrasilApi>();

    public static void AddIsbnBrasilApi(this IServiceCollection services) =>
        services.AddBrasilApi<IIsbnBrasilApi>();
}
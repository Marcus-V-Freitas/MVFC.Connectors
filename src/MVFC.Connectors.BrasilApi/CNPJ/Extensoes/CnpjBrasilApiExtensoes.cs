namespace MVFC.Connectors.BrasilApi.CNPJ.Extensoes;

public static class CnpjBrasilApiExtensoes
{
    public static ICnpjBrasilApi ObterCnpjBrasilApi() =>
        BrasilExtensoes.ObterBrasilApi<ICnpjBrasilApi>();

    public static void AddCnpjBrasilApi(this IServiceCollection services) =>
        services.AddBrasilApi<ICnpjBrasilApi>();
}
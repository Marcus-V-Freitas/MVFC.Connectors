namespace MVFC.Connectors.BrasilApi.DDD.Extensoes;

public static class DddBrasilApiExtensoes
{
    public static IDddBrasilApi ObterDddBrasilApi() =>
        BrasilExtensoes.ObterBrasilApi<IDddBrasilApi>();

    public static void AddDddBrasilApi(this IServiceCollection services) =>
        services.AddBrasilApi<IDddBrasilApi>();
}
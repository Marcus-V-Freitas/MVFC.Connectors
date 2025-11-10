namespace MVFC.Connectors.BrasilApi.Taxa.Extensoes;

public static class TaxaBrasilApiExtensoes
{
    public static ITaxaBrasilApi ObterTaxaBrasilApi() =>
        BrasilExtensoes.ObterBrasilApi<ITaxaBrasilApi>();

    public static void AddTaxaBrasilApi(this IServiceCollection services) =>
        services.AddBrasilApi<ITaxaBrasilApi>();
}
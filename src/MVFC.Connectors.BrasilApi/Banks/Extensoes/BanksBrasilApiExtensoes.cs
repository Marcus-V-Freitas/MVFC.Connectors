namespace MVFC.Connectors.BrasilApi.Banks.Extensoes;

public static class BanksBrasilApiExtensoes
{
    public static IBankBrasilApi ObterBankBrasilApi() =>
         BrasilExtensoes.ObterBrasilApi<IBankBrasilApi>();

    public static void AddBankBrasilApi(this IServiceCollection services) =>
        services.AddBrasilApi<IBankBrasilApi>();
}
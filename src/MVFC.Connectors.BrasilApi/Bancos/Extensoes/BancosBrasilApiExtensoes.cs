namespace MVFC.Connectors.BrasilApi.Bancos.Extensoes;

public static class BancosBrasilApiExtensoes
{
    public static IBancoBrasilApi ObterBankBrasilApi() =>
         BrasilExtensoes.ObterBrasilApi<IBancoBrasilApi>();

    public static void AddBankBrasilApi(this IServiceCollection services) =>
        services.AddBrasilApi<IBancoBrasilApi>();
}
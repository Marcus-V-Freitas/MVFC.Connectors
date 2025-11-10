namespace MVFC.Connectors.BrasilApi.Corretoras.Extensoes;

public static class CorretorasBrasilApiExtensoes
{
    public static ICorretoraBrasilApi ObterCorretoraBrasilApi() =>
        BrasilExtensoes.ObterBrasilApi<ICorretoraBrasilApi>();

    public static void AddCorretoraBrasilApi(this IServiceCollection services) =>
        services.AddBrasilApi<ICorretoraBrasilApi>();
}
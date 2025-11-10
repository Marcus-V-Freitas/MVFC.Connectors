namespace MVFC.Connectors.BrasilApi.PIX.Extensoes;

public static class PixParticipantesBrasilApiExtensoes
{
    public static IPixParticipantesBrasilApi ObterPixParticipanteBrasilApi() =>
        BrasilExtensoes.ObterBrasilApi<IPixParticipantesBrasilApi>();

    public static void AddPixParticipanteBrasilApi(this IServiceCollection services) =>
        services.AddBrasilApi<IPixParticipantesBrasilApi>();
}
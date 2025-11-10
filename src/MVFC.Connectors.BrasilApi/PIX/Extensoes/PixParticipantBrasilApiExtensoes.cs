namespace MVFC.Connectors.BrasilApi.PIX.Extensoes;

public static class PixParticipantBrasilApiExtensoes
{
    public static IPixParticipantBrasilApi ObterPixParticipantBrasilApi() =>
        BrasilExtensoes.ObterBrasilApi<IPixParticipantBrasilApi>();

    public static void AddPixParticipantBrasilApi(this IServiceCollection services) =>
        services.AddBrasilApi<IPixParticipantBrasilApi>();
}
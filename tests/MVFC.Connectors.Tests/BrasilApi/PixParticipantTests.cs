namespace MVFC.Connectors.Tests.BrasilApi;

public sealed class PixParticipantTests
{
    public static TheoryData<IPixParticipantesBrasilApi> Apis =>
        new()
        {
            { PixParticipantesBrasilApiExtensoes.ObterPixParticipanteBrasilApi() },
            { TestsHelpers.ObterApi<IPixParticipantesBrasilApi>(s => s.AddPixParticipanteBrasilApi()) },
        };

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task RecuperarPixParticipantes_DeveRetornarItem(IPixParticipantesBrasilApi api)
    {
        // Arrange & Act
        var pixParticipantes = await api.ObterParticipantesPixAsync();

        // Assert
        pixParticipantes.IsSuccessful.Should().BeTrue();
        pixParticipantes.Content.Should().NotBeNull();
    }
}
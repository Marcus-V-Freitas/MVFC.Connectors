namespace MVFC.Connectors.Tests.BrasilApi;

public sealed class PixParticipantTests : ConnectorTestsBase<IPixParticipantesBrasilApi>
{
    protected override IPixParticipantesBrasilApi ManualApi => PixParticipantesBrasilApiExtensoes.ObterPixParticipanteBrasilApi();

    protected override IPixParticipantesBrasilApi ServiceCollectionApi => TestsHelpers.ObterApi<IPixParticipantesBrasilApi>(s => s.AddPixParticipanteBrasilApi());

    public static TheoryData<RegistrationMode> Modes => [RegistrationMode.Manual, RegistrationMode.ServiceCollection];

    [Theory]
    [MemberData(nameof(Modes))]
    public Task GarantirQueApiEstaConfiguradaEBuscandoDados(RegistrationMode mode) =>
        ValidarConfiguracaoApi(mode);

    protected override Task ExecutarChamadaBasica(IPixParticipantesBrasilApi api) =>
        api.ObterParticipantesPixAsync();

    [Fact]
    public async Task RecuperarPixParticipantes_DeveRetornarItem()
    {
        // Arrange & Act
        var pixParticipantes = await ManualApi.ObterParticipantesPixAsync();

        // Assert
        pixParticipantes.Should().BeSuccessfulOrSkip("BrasilApi (PixParticipantes)");
    }
}

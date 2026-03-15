namespace MVFC.Connectors.Tests.Financas;

public sealed class InvestoTests : ConnectorTestsBase<IInvestoApi>
{
    protected override IInvestoApi ManualApi => InvestoExtensoes.ObterInvestoApi();

    protected override IInvestoApi ServiceCollectionApi => TestsHelpers.ObterApi<IInvestoApi>(s => s.AddInvesto());

    public static TheoryData<RegistrationMode> Modes => [RegistrationMode.Manual, RegistrationMode.ServiceCollection];

    [Theory]
    [MemberData(nameof(Modes))]
    public Task GarantirQueApiEstaConfiguradaEBuscandoDados(RegistrationMode mode) =>
        ValidarConfiguracaoApi(mode);

    protected override Task ExecutarChamadaBasica(IInvestoApi api) =>
        api.ObterEtfPorNomeAsync("GPUS11");

    [Fact]
    public async Task ObterEtfPorNome_DeveRetornarItemAsync()
    {
        // Arrange
        const string NOME = "GPUS11";

        // Act
        var investoEtf = await ManualApi.ObterEtfPorNomeAsync(NOME);

        // Assert
        investoEtf.IsSuccessful.Should().BeTrue();
        investoEtf.Content.Should().NotBeNull();
        investoEtf.Content!.Nome.Should().Be(NOME);
    }
}

namespace MVFC.Connectors.Tests.Developer;

public sealed class FishFisTests : ConnectorTestsBase<IFishFishApi>
{
    protected override IFishFishApi ManualApi => FishFishExtensoes.ObterFishFishApi();

    protected override IFishFishApi ServiceCollectionApi => TestsHelpers.ObterApi<IFishFishApi>(s => s.AddFishFish());

    public static TheoryData<RegistrationMode> Modes => [RegistrationMode.Manual, RegistrationMode.ServiceCollection];

    [Theory]
    [MemberData(nameof(Modes))]
    public Task GarantirQueApiEstaConfiguradaEBuscandoDados(RegistrationMode mode) =>
        ValidarConfiguracaoApi(mode);

    protected override Task ExecutarChamadaBasica(IFishFishApi api) =>
        api.ObterPhishingAsync();

    [Fact]
    public async Task ObterPhishing_DeveRetornarItemAsync()
    {
        // Arrange & Act
        var phishing = await ManualApi.ObterPhishingAsync();

        // Assert
        phishing.IsSuccessful.Should().BeTrue();
        phishing.Content.Should().NotBeNullOrEmpty();
    }
}

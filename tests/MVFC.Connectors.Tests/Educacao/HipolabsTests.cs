namespace MVFC.Connectors.Tests.Educacao;

public sealed class HipolabsTests : ConnectorTestsBase<IHipolabsApi>
{
    protected override IHipolabsApi ManualApi => HipolabsExtensoes.ObterHipolabsApi();
    protected override IHipolabsApi ServiceCollectionApi => TestsHelpers.ObterApi<IHipolabsApi>(s => s.AddHipolabs());

    public static TheoryData<RegistrationMode> Modes => new() { RegistrationMode.Manual, RegistrationMode.ServiceCollection };

    [Theory]
    [MemberData(nameof(Modes))]
    public Task GarantirQueApiEstaConfiguradaEBuscandoDados(RegistrationMode mode) =>
        ValidarConfiguracaoApi(mode);

    protected override Task ExecutarChamadaBasica(IHipolabsApi api) =>
        api.ObterUniversidadesPorPaisAsync("Brazil");

    [Fact]
    public async Task ObterUniversidadesPorPais_DeveRetornarItemAsync()
    {
        // Arrange
        const string PAIS = "Brazil";

        // Act
        var phishing = await ManualApi.ObterUniversidadesPorPaisAsync(PAIS);

        // Assert
        phishing.IsSuccessful.Should().BeTrue();
        phishing.Content.Should().NotBeNullOrEmpty();
    }
}
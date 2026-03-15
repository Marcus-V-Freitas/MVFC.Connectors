namespace MVFC.Connectors.Tests.Geo;

public sealed class ViaCepTests : ConnectorTestsBase<IViaCepApi>
{
    protected override IViaCepApi ManualApi => ViaCepApiExtensoes.ObterViaCepApi();

    protected override IViaCepApi ServiceCollectionApi => TestsHelpers.ObterApi<IViaCepApi>(s => s.AddViaCep());

    public static TheoryData<RegistrationMode> Modes => [RegistrationMode.Manual, RegistrationMode.ServiceCollection];

    [Theory]
    [MemberData(nameof(Modes))]
    public Task GarantirQueApiEstaConfiguradaEBuscandoDados(RegistrationMode mode) =>
        ValidarConfiguracaoApi(mode);

    protected override Task ExecutarChamadaBasica(IViaCepApi api) =>
        api.ObterDadosPorCepAsync("04514103");

    [Fact]
    public async Task ObterInfosDoCepAsync_DeveRetornarItemAsync()
    {
        // Arrange
        const string CEP = "04514103";

        // Act
        var viaCepDados = await ManualApi.ObterDadosPorCepAsync(CEP);

        // Assert
        viaCepDados.IsSuccessful.Should().BeTrue();
        viaCepDados.Content.Should().NotBeNull();
    }
}

namespace MVFC.Connectors.Tests.Geo;

public sealed class GeocodingTests : ConnectorTestsBase<IGeocodingApi>
{
    protected override IGeocodingApi ManualApi => GeocodingExtensoes.ObterGeocodingApi();

    protected override IGeocodingApi ServiceCollectionApi => TestsHelpers.ObterApi<IGeocodingApi>(s => s.AddGeocoding());

    public static TheoryData<RegistrationMode> Modes => [RegistrationMode.Manual, RegistrationMode.ServiceCollection];

    [Theory]
    [MemberData(nameof(Modes))]
    public Task GarantirQueApiEstaConfiguradaEBuscandoDados(RegistrationMode mode) =>
        ValidarConfiguracaoApi(mode);

    protected override Task ExecutarChamadaBasica(IGeocodingApi api) =>
        api.ObterGeografiaPorNomeDaCidadeAsync("Sao Paulo");

    [Fact]
    public async Task ObterGeografia_DeveRetornarItemAsync()
    {
        // Arrange
        const string CIDADE = "Sao Paulo";

        // Act
        var geografia = await ManualApi.ObterGeografiaPorNomeDaCidadeAsync(CIDADE);

        // Assert
        geografia.IsSuccessful.Should().BeTrue();
        geografia.Content.Should().NotBeNull();
    }
}

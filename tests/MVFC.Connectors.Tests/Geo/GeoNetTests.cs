namespace MVFC.Connectors.Tests.Geo;

public sealed class GeoNetTests : ConnectorTestsBase<IGeoNetApi>
{
    protected override IGeoNetApi ManualApi => GeoNetApiExtensoes.ObterGeoNetApi();

    protected override IGeoNetApi ServiceCollectionApi => TestsHelpers.ObterApi<IGeoNetApi>(s => s.AddGeoNet());

    public static TheoryData<RegistrationMode> Modes => [RegistrationMode.Manual, RegistrationMode.ServiceCollection];

    [Theory]
    [MemberData(nameof(Modes))]
    public Task GarantirQueApiEstaConfiguradaEBuscandoDados(RegistrationMode mode) =>
        ValidarConfiguracaoApi(mode);

    protected override Task ExecutarChamadaBasica(IGeoNetApi api) =>
        api.ObterDnsGeosPorDominioAsync("google.com");

    [Fact]
    public async Task ObterDnsGeosPorDominioAsync_DeveRetornarItemAsync()
    {
        // Arrange
        const string DOMINIO = "google.com";

        // Act
        var dnsGeos = await ManualApi.ObterDnsGeosPorDominioAsync(DOMINIO);

        // Assert
        dnsGeos.IsSuccessful.Should().BeTrue();
        dnsGeos.Content.Should().NotBeNullOrEmpty();
    }
}

namespace MVFC.Connectors.Tests.Developer;

public sealed class IpTests : ConnectorTestsBase<IIpApi>
{
    protected override IIpApi ManualApi => IpApiExtensoes.ObterIpApi();

    protected override IIpApi ServiceCollectionApi => TestsHelpers.ObterApi<IIpApi>(s => s.AddIp());

    public static TheoryData<RegistrationMode> Modes => [RegistrationMode.Manual, RegistrationMode.ServiceCollection];

    [Theory]
    [MemberData(nameof(Modes))]
    public Task GarantirQueApiEstaConfiguradaEBuscandoDados(RegistrationMode mode) =>
        ValidarConfiguracaoApi(mode);

    protected override Task ExecutarChamadaBasica(IIpApi api) =>
        api.ObterIpPorNumeroAsync("52.46.64.223");

    [Fact]
    public async Task ObterPhishing_DeveRetornarItemAsync()
    {
        // Arrange
        const string NUMERO = "52.46.64.223";

        // Act
        var ip = await ManualApi.ObterIpPorNumeroAsync(NUMERO);

        // Assert
        ip.IsSuccessful.Should().BeTrue();
        ip.Content.Should().NotBeNull();
    }
}

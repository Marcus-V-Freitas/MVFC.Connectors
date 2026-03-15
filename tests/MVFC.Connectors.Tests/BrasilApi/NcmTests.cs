namespace MVFC.Connectors.Tests.BrasilApi;

public sealed class NcmTests : ConnectorTestsBase<INcmBrasilApi>
{
    protected override INcmBrasilApi ManualApi => NcmBrasilApiExtensoes.ObterNcmBrasilApi();

    protected override INcmBrasilApi ServiceCollectionApi => TestsHelpers.ObterApi<INcmBrasilApi>(s => s.AddNcmBrasilApi());

    public static TheoryData<RegistrationMode> Modes => [RegistrationMode.Manual, RegistrationMode.ServiceCollection];

    [Theory]
    [MemberData(nameof(Modes))]
    public Task GarantirQueApiEstaConfiguradaEBuscandoDados(RegistrationMode mode) =>
        ValidarConfiguracaoApi(mode);

    protected override Task ExecutarChamadaBasica(INcmBrasilApi api) =>
        api.ObterNcmsAsync();

    [Fact]
    public async Task ObterNcmsAsync_DeveRetornarListaDeNcm()
    {
        // Arrange & Act
        var ncms = await ManualApi.ObterNcmsAsync();

        // Assert
        ncms.IsSuccessStatusCode.Should().BeTrue();
        ncms.Content.Should().NotBeNull();
    }

    [Fact]
    public async Task ObterNcmsPorCodigoAsync_DeveRetornarListaDeNcm()
    {
        // Arrange
        const string CODIGO = "0101";

        // Act
        var ncms = await ManualApi.ObterNcmsPorCodigoAsync(CODIGO);

        // Assert
        ncms.IsSuccessStatusCode.Should().BeTrue();
        ncms.Content.Should().NotBeNull();
    }

    [Fact]
    public async Task ObterNcmPorCodigoAsync_DeveRetornarNcm()
    {
        // Arrange
        const string CODIGO = "0101.2";

        // Act
        var ncm = await ManualApi.ObterNcmPorCodigoAsync(CODIGO);

        // Assert
        ncm.IsSuccessStatusCode.Should().BeTrue();
        ncm.Content.Should().NotBeNull();
        ncm.Content?.NumeroAto.Should().Be("272");
    }
}

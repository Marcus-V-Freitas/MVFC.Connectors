namespace MVFC.Connectors.Tests.BrasilApi;

public sealed class FeriadoTests : ConnectorTestsBase<IFeriadoBrasilApi>
{
    protected override IFeriadoBrasilApi ManualApi => FeriadoBrasilApiExtensoes.ObterFeriadoBrasilApi();

    protected override IFeriadoBrasilApi ServiceCollectionApi => TestsHelpers.ObterApi<IFeriadoBrasilApi>(s => s.AddFeriadoBrasilApi());

    public static TheoryData<RegistrationMode> Modes => [RegistrationMode.Manual, RegistrationMode.ServiceCollection];

    [Theory]
    [MemberData(nameof(Modes))]
    public Task GarantirQueApiEstaConfiguradaEBuscandoDados(RegistrationMode mode) =>
        ValidarConfiguracaoApi(mode);

    protected override Task ExecutarChamadaBasica(IFeriadoBrasilApi api) =>
        api.ObterFeriadosPorAnoAsync(2025);

    [Fact]
    public async Task RecuperarFeriadoPorAno_DeveRetornarItem()
    {
        // Arrange
        const int ANO = 2025;

        // & Act
        var feriados = await ManualApi.ObterFeriadosPorAnoAsync(ANO);

        // Assert
        feriados.IsSuccessful.Should().BeTrue();
        feriados.Content.Should().NotBeNull();
        feriados.Content.Should().Contain(f => f.Name == "Natal");
    }
}

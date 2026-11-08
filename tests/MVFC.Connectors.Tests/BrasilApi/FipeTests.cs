namespace MVFC.Connectors.Tests.BrasilApi;

public sealed class FipeTests : ConnectorTestsBase<IFipeBrasilApi>
{
    protected override IFipeBrasilApi ManualApi => FipeBrasilApiExtensoes.ObterFipeBrasilApi();

    protected override IFipeBrasilApi ServiceCollectionApi => TestsHelpers.ObterApi<IFipeBrasilApi>(s => s.AddFipeBrasilApi());

    public static TheoryData<RegistrationMode> Modes => [RegistrationMode.Manual, RegistrationMode.ServiceCollection];

    [Theory]
    [MemberData(nameof(Modes))]
    public Task GarantirQueApiEstaConfiguradaEBuscandoDados(RegistrationMode mode) =>
        ValidarConfiguracaoApi(mode);

    protected override Task ExecutarChamadaBasica(IFipeBrasilApi api) =>
        api.ObterTabelasFipeAsync();

    [Fact]
    public async Task RecuperarMarcas_DeveRetornarDadosCorretos()
    {
        // Arrange
        const FipeTipoVeiculo TIPO_VEICULO = FipeTipoVeiculo.Caminhoes;

        // Act
        var marcas = await ManualApi.ObterMarcasPorTipoVeiculoAsync(TIPO_VEICULO);

        // Assert
        marcas.IsSuccessful.Should().BeTrue();
        marcas.Content.Should().NotBeNullOrEmpty();
    }
}

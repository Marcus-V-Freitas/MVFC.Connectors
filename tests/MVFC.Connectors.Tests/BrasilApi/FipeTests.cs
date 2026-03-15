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
    public async Task RecuperarVeiculos_DeveRetornarDadosCorretos()
    {
        // Arrange &
        const string CODIGO_FIPE = "004321-4";

        // Act
        var veiculos = await ManualApi.ObterVeiculosPorCodigoAsync(CODIGO_FIPE);

        // Assert
        veiculos.IsSuccessful.Should().BeTrue();
        veiculos.Content.Should().NotBeNullOrEmpty();
        veiculos.Content![0].CodigoFipe.Should().Be(CODIGO_FIPE);

        // Act
        var tabelas = await ManualApi.ObterTabelasFipeAsync();

        // Assert
        tabelas.IsSuccessful.Should().BeTrue();
        tabelas.Content.Should().NotBeNullOrEmpty();
    }

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

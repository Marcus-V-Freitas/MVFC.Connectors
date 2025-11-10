namespace MVFC.Connectors.Tests.BrasilApi;

public sealed class FipeTests
{
    public static TheoryData<IFipeBrasilApi> Apis =>
       [
           FipeBrasilApiExtensoes.ObterFipeBrasilApi(),
            TestsHelpers.ObterApi<IFipeBrasilApi>(s => s.AddFipeBrasilApi()),
       ];

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task RecuperarVeiculos_DeveRetornarDadosCorretos(IFipeBrasilApi api)
    {
        // Arrange &
        const string codigoFipe = "004321-4";

        // Act
        var veiculos = await api.ObterVeiculosPorCodigoAsync(codigoFipe);

        // Assert
        veiculos.IsSuccessful.Should().BeTrue();
        veiculos.Content.Should().NotBeNullOrEmpty();
        veiculos.Content![0].CodigoFipe.Should().Be(codigoFipe);

        // Act
        var tabelas = await api.ObterTabelasFipeAsync();

        // Assert
        tabelas.IsSuccessful.Should().BeTrue();
        tabelas.Content.Should().NotBeNullOrEmpty();
    }

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task RecuperarMarcas_DeveRetornarDadosCorretos(IFipeBrasilApi api)
    {
        // Arrange
        const FipeTipoVeiculo tipoVeiculo = FipeTipoVeiculo.Caminhoes;

        // Act
        var marcas = await api.ObterMarcasPorTipoVeiculoAsync(tipoVeiculo);

        // Assert
        marcas.IsSuccessful.Should().BeTrue();
        marcas.Content.Should().NotBeNullOrEmpty();
    }
}
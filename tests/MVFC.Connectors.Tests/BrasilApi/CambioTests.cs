namespace MVFC.Connectors.Tests.BrasilApi;

public sealed class CambioTests : ConnectorTestsBase<ICambioBrasilApi>
{
    protected override ICambioBrasilApi ManualApi => CambioBrasilApiExtensoes.ObterCambioBrasilApi();

    protected override ICambioBrasilApi ServiceCollectionApi => TestsHelpers.ObterApi<ICambioBrasilApi>(s => s.AddCambioBrasilApi());

    public static TheoryData<RegistrationMode> Modes => [RegistrationMode.Manual, RegistrationMode.ServiceCollection];

    [Theory]
    [MemberData(nameof(Modes))]
    public Task GarantirQueApiEstaConfiguradaEBuscandoDados(RegistrationMode mode) =>
        ValidarConfiguracaoApi(mode);

    protected override Task ExecutarChamadaBasica(ICambioBrasilApi api) =>
        api.ObterCambiosAsync();

    [Fact]
    public async Task RecuperarTodasAsMoedas_Console_DeveRetornarItens()
    {
        // Arrange & Act
        var moedas = await ManualApi.ObterCambiosAsync();

        // Assert
        moedas.IsSuccessful.Should().BeTrue();
        moedas.Content.Should().NotBeNull();
        moedas.Content.Should().NotBeEmpty();
        moedas.Content.Should().BeEquivalentTo(moedas.Content);
    }

    [Fact]
    public async Task RecuperarCotacaoPorData_Console_DeveRetornarCotacao()
    {
        // Arrange
        const string MOEDA = "USD";
        const string DATA = "2024-01-02";

        // & Act
        var cotacao = await ManualApi.ObterCambioPorMoedaEDataAsync(MOEDA, DATA);

        // Assert
        cotacao.IsSuccessful.Should().BeTrue();
        cotacao.Content.Should().NotBeNull();
        cotacao.Content?.Moeda.Should().Be(MOEDA);
        cotacao.Content?.Data.Should().Be(DATA);
        cotacao.Content?.Cotacoes.Should().NotBeNull();
        cotacao.Content?.Cotacoes.Should().NotBeEmpty();
    }
}

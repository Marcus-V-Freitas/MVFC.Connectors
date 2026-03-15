namespace MVFC.Connectors.Tests.Financas;

public sealed class YahooTests : ConnectorTestsBase<IYahooApi>
{
    protected override IYahooApi ManualApi => YahooExtensoes.ObterYahooApi();

    protected override IYahooApi ServiceCollectionApi => TestsHelpers.ObterApi<IYahooApi>(s => s.AddYahoo());

    public static TheoryData<RegistrationMode> Modes => [RegistrationMode.Manual, RegistrationMode.ServiceCollection];

    [Theory]
    [MemberData(nameof(Modes))]
    public Task GarantirQueApiEstaConfiguradaEBuscandoDados(RegistrationMode mode) =>
        ValidarConfiguracaoApi(mode);

    protected override Task ExecutarChamadaBasica(IYahooApi api) =>
        api.ObterMoedaPorNomeEPeriodoAsync("BRL");

    [Fact]
    public async Task ObterMoedaPorNome_DeveRetornarItemAsync()
    {
        // Arrange
        const string MOEDA = "BRL";

        // Act
        var yahooMoeda = await ManualApi.ObterMoedaPorNomeEPeriodoAsync(MOEDA);

        // Assert
        yahooMoeda.IsSuccessful.Should().BeTrue();
        yahooMoeda.Content.Should().NotBeNull();
        yahooMoeda.Content!.Chart.Result[0].Meta.Symbol.Should().Be(MOEDA);
    }
}

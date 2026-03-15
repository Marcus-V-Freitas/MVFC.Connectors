namespace MVFC.Connectors.Tests.Financas;

public sealed class RedditStockTests : ConnectorTestsBase<IRedditStockApi>
{
    protected override IRedditStockApi ManualApi => RedditExtensoes.ObterRedditStockApi();

    protected override IRedditStockApi ServiceCollectionApi => TestsHelpers.ObterApi<IRedditStockApi>(s => s.AddRedditStock());

    public static TheoryData<RegistrationMode> Modes => [RegistrationMode.Manual, RegistrationMode.ServiceCollection];

    [Theory]
    [MemberData(nameof(Modes))]
    public Task GarantirQueApiEstaConfiguradaEBuscandoDados(RegistrationMode mode) =>
        ValidarConfiguracaoApi(mode);

    protected override Task ExecutarChamadaBasica(IRedditStockApi api) =>
        api.ObterTopStocksAsync();

    [Fact]
    public async Task ObterStocks_DeveRetornarItemAsync()
    {
        // Arrange & Act
        var stocks = await ManualApi.ObterTopStocksAsync();

        // Assert
        stocks.IsSuccessful.Should().BeTrue();
        stocks.Content.Should().NotBeNullOrEmpty();
    }
}

namespace MVFC.Connectors.Tests.Financas;

public sealed class YahooTests
{
    public static TheoryData<IYahooApi> Apis =>
    new()
    {
        { YahooExtensoes.ObterYahooApi() },
        { TestsHelpers.ObterApi<IYahooApi>(s => s.AddYahoo()) },
    };

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task ObterMoedaPorNome_DeveRetornarItemAsync(IYahooApi api)
    {
        // Arrange
        const string moeda = "BRL";

        // Act
        var yahooMoeda = await api.ObterMoedaPorNomeEPeriodoAsync(moeda);

        // Assert
        yahooMoeda.IsSuccessful.Should().BeTrue();
        yahooMoeda.Content.Should().NotBeNull();
        yahooMoeda.Content!.Chart.Result[0].Meta.Symbol.Should().Be(moeda);
    }
}

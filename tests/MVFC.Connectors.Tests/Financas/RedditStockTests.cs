namespace MVFC.Connectors.Tests.Financas;

public sealed class RedditStockTests
{
    public static TheoryData<IRedditStockApi> Apis =>
     [
          RedditExtensoes.ObterRedditStockApi(),
          TestsHelpers.ObterApi<IRedditStockApi>(s => s.AddRedditStock()),
     ];

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task ObterStocks_DeveRetornarItemAsync(IRedditStockApi api)
    {
        // Arrange & Act
        var stocks = await api.ObterTopStocksAsync();

        // Assert
        stocks.IsSuccessful.Should().BeTrue();
        stocks.Content.Should().NotBeNullOrEmpty();
    }
}
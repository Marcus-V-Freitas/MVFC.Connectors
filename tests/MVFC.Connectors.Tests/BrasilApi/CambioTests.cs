namespace MVFC.Connectors.Tests.BrasilApi;

public sealed class CambioTests
{
    public static TheoryData<ICambioBrasilApi> Apis =>
        [
            CambioBrasilApiExtensoes.ObterCambioBrasilApi(),
            TestsHelpers.ObterApi<ICambioBrasilApi>(s => s.AddCambioBrasilApi()),
        ];

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task RecuperarTodasAsMoedas_Console_DeveRetornarItens(ICambioBrasilApi api)
    {
        // Arrange & Act
        var moedas = await api.GetCurrenciesAsync();

        // Assert
        moedas.IsSuccessful.Should().BeTrue();
        moedas.Content.Should().NotBeNull();
        moedas.Content.Should().NotBeEmpty();
        moedas.Content.Should().BeEquivalentTo(moedas.Content);
    }

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task RecuperarCotacaoPorData_Console_DeveRetornarCotacao(ICambioBrasilApi api)
    {
        // Arrange
        const string moeda = "USD";
        const string data = "2024-01-02";

        // & Act
        var cotacao = await api.GetCurrencyQuotationByDateAsync(moeda, data);

        // Assert
        cotacao.IsSuccessful.Should().BeTrue();
        cotacao.Content.Should().NotBeNull();
        cotacao.Content?.Moeda.Should().Be(moeda);
        cotacao.Content?.Data.Should().Be(data);
        cotacao.Content?.Cotacoes.Should().NotBeNull();
        cotacao.Content?.Cotacoes.Should().NotBeEmpty();
    }
}
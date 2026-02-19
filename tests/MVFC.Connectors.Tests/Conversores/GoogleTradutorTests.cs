namespace MVFC.Connectors.Tests.Conversores;

public sealed class GoogleTradutorTests
{
    public static TheoryData<IGoogleTradutorApi> Apis =>
    new()
    {
        { GoogleTradutorExtensoes.ObterGoogleTradutorApi() },
        { TestsHelpers.ObterApi<IGoogleTradutorApi>(s => s.AddGoogleTradutor()) },
    };

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task Traduzir_DeveRetornarItemAsync(IGoogleTradutorApi api)
    {
        // Arrange
        const string textoDeEntrada = "Hello World";
        const string textoEsperado = "Olá Mundo";

        // Act
        var textoGerado = await api.TraduzirTextoAsync(textoDeEntrada, "en", "pt-br");

        // Assert
        textoGerado.IsSuccessStatusCode.Should().BeTrue();
        textoGerado.Content.Should().NotBeNullOrEmpty();
        textoGerado.Content.Should().BeEquivalentTo(textoEsperado);
    }
}
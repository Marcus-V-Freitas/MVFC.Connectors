namespace MVFC.Connectors.Tests.Conversores;

public sealed class GoogleTradutorTests
{
    public static TheoryData<IGoogleTradutorApi> Apis =>
      [
          GoogleTradutorExtensoes.ObterGoogleTradutorApi(),
          TestsHelpers.ObterApi<IGoogleTradutorApi>(s => s.AddGoogleTradutor()),
       ];

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
        textoGerado.Should().BeEquivalentTo(textoEsperado);
    }
}
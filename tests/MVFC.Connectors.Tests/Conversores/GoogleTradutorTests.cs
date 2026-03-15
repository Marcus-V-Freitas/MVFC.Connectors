namespace MVFC.Connectors.Tests.Conversores;

public sealed class GoogleTradutorTests : ConnectorTestsBase<IGoogleTradutorApi>
{
    protected override IGoogleTradutorApi ManualApi => GoogleTradutorExtensoes.ObterGoogleTradutorApi();

    protected override IGoogleTradutorApi ServiceCollectionApi => TestsHelpers.ObterApi<IGoogleTradutorApi>(s => s.AddGoogleTradutor());

    public static TheoryData<RegistrationMode> Modes => [RegistrationMode.Manual, RegistrationMode.ServiceCollection];

    [Theory]
    [MemberData(nameof(Modes))]
    public Task GarantirQueApiEstaConfiguradaEBuscandoDados(RegistrationMode mode) =>
        ValidarConfiguracaoApi(mode);

    protected override Task ExecutarChamadaBasica(IGoogleTradutorApi api) =>
        api.TraduzirTextoAsync("Hello World", "en", "pt-br");

    [Fact]
    public async Task Traduzir_DeveRetornarItemAsync()
    {
        // Arrange
        const string TEXTO_DE_ENTRADA = "Hello World";
        const string TEXTO_ESPERADO = "Olá Mundo";

        // Act
        var textoGerado = await ManualApi.TraduzirTextoAsync(TEXTO_DE_ENTRADA, "en", "pt-br");

        // Assert
        textoGerado.IsSuccessStatusCode.Should().BeTrue();
        textoGerado.Content.Should().NotBeNullOrEmpty();
        textoGerado.Content.Should().BeEquivalentTo(TEXTO_ESPERADO);
    }
}

namespace MVFC.Connectors.Tests.IA;

public sealed class TextoPollinationsTests : ConnectorTestsBase<ITextoPollinationsApi>
{
    protected override ITextoPollinationsApi ManualApi => TextoPollinationsExtensoes.ObterTextoPollinationsApi();

    protected override ITextoPollinationsApi ServiceCollectionApi => TestsHelpers.ObterApi<ITextoPollinationsApi>(s => s.AddTextoPollinations());

    public static TheoryData<RegistrationMode> Modes => [RegistrationMode.Manual, RegistrationMode.ServiceCollection];

    [Theory]
    [MemberData(nameof(Modes))]
    public Task GarantirQueApiEstaConfiguradaEBuscandoDados(RegistrationMode mode) =>
        ValidarConfiguracaoApi(mode);

    protected override Task ExecutarChamadaBasica(ITextoPollinationsApi api) =>
        api.GerarTextoAsync("Quem é Darth Vader?");

    [Fact]
    public async Task GerarTexto_DeveRetornarNaoVazioAsync()
    {
        // Arrange
        const string PROMPT = "Quem é Darth Vader?";

        // Act
        var textoGerado = await ManualApi.GerarTextoAsync(PROMPT);

        // Assert
        textoGerado.IsSuccessful.Should().BeTrue();
        textoGerado.Content.Should().NotBeNull();
    }
}

namespace MVFC.Connectors.Tests.Conversores;

public sealed class DictionaryApiTests : ConnectorTestsBase<IDictionaryApi>
{
    protected override IDictionaryApi ManualApi => DictionaryApiExtensoes.ObterDictionaryApi();

    protected override IDictionaryApi ServiceCollectionApi => TestsHelpers.ObterApi<IDictionaryApi>(s => s.AddDictionaryApi());

    public static TheoryData<RegistrationMode> Modes => [RegistrationMode.Manual, RegistrationMode.ServiceCollection];

    [Theory]
    [MemberData(nameof(Modes))]
    public Task GarantirQueApiEstaConfiguradaEBuscandoDados(RegistrationMode mode) =>
        ValidarConfiguracaoApi(mode);

    protected override Task ExecutarChamadaBasica(IDictionaryApi api) =>
        api.ObterSignificadoPorPalavraAsync("Hello");

    [Fact]
    public async Task ObterDictionaryWord_DeveRetornarItemAsync()
    {
        // Arrange
        const string WORD = "Hello";

        // Act
        var significado = await ManualApi.ObterSignificadoPorPalavraAsync(WORD);

        // Assert
        significado.IsSuccessStatusCode.Should().BeTrue();
        significado.Content.Should().NotBeNullOrEmpty();
        significado.Content![0].Word.Should().BeEquivalentTo(WORD);
    }
}

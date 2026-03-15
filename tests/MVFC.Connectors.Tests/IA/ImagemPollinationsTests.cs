namespace MVFC.Connectors.Tests.IA;

public sealed class ImagemPollinationsTests : ConnectorTestsBase<IImagemPollinationsApi>
{
    private readonly ImagemPollinationsClassFixture _fixture = new();

    protected override IImagemPollinationsApi ManualApi => ImagemPollinationExtensoes.ObterImagemPollinationsApi();

    protected override IImagemPollinationsApi ServiceCollectionApi => TestsHelpers.ObterApi<IImagemPollinationsApi>(s => s.AddImagemPollinations());

    public static TheoryData<RegistrationMode> Modes => [RegistrationMode.Manual, RegistrationMode.ServiceCollection];

    [Theory]
    [MemberData(nameof(Modes))]
    public Task GarantirQueApiEstaConfiguradaEBuscandoDados(RegistrationMode mode) =>
        ValidarConfiguracaoApi(mode);

    protected override Task ExecutarChamadaBasica(IImagemPollinationsApi api) =>
        api.GerarImagemAsync("Gere uma imagem de Darth Vader");

    [Fact]
    public async Task GerarImagem_DeveRetornarNaoVazioAsync()
    {
        // Arrange
        const string PROMPT = "Gere uma imagem de Darth Vader";
        var imagemGeradaPath = Path.Combine(_fixture.ARQUIVO_PATH, $"{Guid.NewGuid()}.jpg");

        // Act
        var imagemGerada = await ManualApi.GerarImagemAsync(PROMPT);

        // Assert
        _fixture.AssertArquivoGerado(imagemGerada, imagemGeradaPath);
    }
}

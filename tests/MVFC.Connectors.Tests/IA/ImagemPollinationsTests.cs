namespace MVFC.Connectors.Tests.IA;

public sealed class ImagemPollinationsTests : DirectoryHelper
{
    public static TheoryData<IImagemPollinationsApi> Apis =>
    new()
    {
        { ImagemPollinationExtensoes.ObterImagemPollinationsApi() },
        { TestsHelpers.ObterApi<IImagemPollinationsApi>(s => s.AddImagemPollinations()) },
    };

    protected override string ARQUIVO_PATH => "temp_folder_pollinations";

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task GerarImagem_DeveRetornarNaoVazioAsync(IImagemPollinationsApi api)
    {
        // Arrange
        const string prompt = "Gere uma imagem de Darth Vader";
        var imagemGeradaPath = Path.Combine(ARQUIVO_PATH, $"{Guid.NewGuid()}.jpg");

        // Act
        var imagemGerada = await api.GerarImagemAsync(prompt);

        // Assert
        AssertArquivoGerado(imagemGerada, imagemGeradaPath);
    }
}
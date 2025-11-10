namespace MVFC.Connectors.Tests.Helpers;

public abstract class DirectoryHelper : IAsyncLifetime
{
    protected abstract string ARQUIVO_PATH { get; }

    public async Task InitializeAsync()
    {
        await DeleteDirectoryAsync(ARQUIVO_PATH).ConfigureAwait(false);
        Directory.CreateDirectory(ARQUIVO_PATH);
    }

    public async Task DisposeAsync() =>
        await DeleteDirectoryAsync(ARQUIVO_PATH).ConfigureAwait(false);

    protected static async Task DeleteDirectoryAsync(string path)
    {
        if (Directory.Exists(path))
            Directory.Delete(path, recursive: true);

        await Task.CompletedTask.ConfigureAwait(false);
    }

    protected static void AssertArquivoGerado(ApiResponse<Stream> arquivoGerado, string arquivoGeradoPath)
    {
        arquivoGerado.IsSuccessful.Should().BeTrue();
        arquivoGerado.Content.Should().NotBeNull();

        using var fileStream = new FileStream(arquivoGeradoPath, FileMode.Create, FileAccess.Write);
        arquivoGerado.Content!.CopyTo(fileStream);

        File.Exists(arquivoGeradoPath).Should().BeTrue();
    }
}

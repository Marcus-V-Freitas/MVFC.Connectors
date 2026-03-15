namespace MVFC.Connectors.Tests.Helpers;

public abstract class DirectoryHelper : IDisposable
{
    public abstract string ARQUIVO_PATH { get; }

    protected DirectoryHelper()
    {
    }

    public void AssertArquivoGerado(ApiResponse<Stream> arquivoGerado, string arquivoGeradoPath)
    {
        ArgumentNullException.ThrowIfNull(arquivoGerado);

        if (!Directory.Exists(ARQUIVO_PATH))
        {
            Directory.CreateDirectory(ARQUIVO_PATH);
        }

        arquivoGerado.IsSuccessful.Should().BeTrue();
        arquivoGerado.Content.Should().NotBeNull();
        using (var fileStream = File.Create(arquivoGeradoPath))
        {
            arquivoGerado.Content!.CopyTo(fileStream);
        }

        File.Exists(arquivoGeradoPath).Should().BeTrue();
    }

    protected virtual void Dispose(bool disposing)
    {
        if (disposing)
        {
            if (Directory.Exists(ARQUIVO_PATH))
            {
                Directory.Delete(ARQUIVO_PATH, true);
            }
        }
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

    public static async Task<T> ObterDoArquivoAsync<T>(JsonSerializerOptions options, params string[] paths)
    {
        var basePath = AppContext.BaseDirectory;
        var fullPath = Path.Combine([basePath, .. paths]);
        var json = await File.ReadAllTextAsync(fullPath).ConfigureAwait(false);
        return JsonSerializer.Deserialize<T>(json, options)!;
    }
}

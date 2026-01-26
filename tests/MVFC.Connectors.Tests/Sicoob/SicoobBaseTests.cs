namespace MVFC.Connectors.Tests.Sicoob;

public abstract class SicoobBaseTests
{
    protected static readonly SicoobConfig _config = new(
        SecretsHelper.ObterSecretPorChave("Sicoob:ClientId")!,
        SecretsHelper.ObterSecretPorChave("Sicoob:AccessToken")!, true);

    protected static readonly JsonSerializerOptions _jsonOptions = new()
    {
        NumberHandling = JsonNumberHandling.AllowReadingFromString,
        PropertyNameCaseInsensitive = true,
        DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull,
        WriteIndented = true,
    };

    protected static async Task<T> ObterPorArquivoAsync<T>(string pasta, string nomeArquivo) =>
        await DirectoryHelper.ObterDoArquivoAsync<T>(_jsonOptions, "Sicoob", "Jsons", pasta, nomeArquivo);

}
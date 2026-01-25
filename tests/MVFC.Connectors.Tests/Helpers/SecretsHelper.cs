namespace MVFC.Connectors.Tests.Helpers;

public sealed class SecretsHelper
{
    private static readonly IConfigurationRoot _config = new ConfigurationBuilder()
                                                                .AddUserSecrets<SecretsHelper>()
                                                                .Build();

    private SecretsHelper() {}

    public static string? ObterSecretPorChave(string chave) => 
        _config[chave];
}
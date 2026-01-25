namespace MVFC.Connectors.Sicoob.Config;

public sealed record SicoobConfig(
    string ClientId,
    string AccessToken,
    bool SandBox = false);
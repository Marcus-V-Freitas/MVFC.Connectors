namespace MVFC.Connectors.Sicoob.Config;

public sealed record SicoobConfig(
    string ClientId,
    string ClientSecret,
    bool SandBox = false);
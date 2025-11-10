namespace MVFC.Connectors.Commons.Settings;

public sealed record ConnectorsSettings(
    LogLevel LogLevel = LogLevel.Information,
    HttpSettings? HttpSettings = null,
    RefitSettings? RefitSettings = null);


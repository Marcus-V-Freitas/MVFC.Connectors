namespace MVFC.Connectors.Commons.Settings;

public sealed record ConnectorsSettingsServices(
    RefitSettings? RefitSettings = null,
    Action<HttpSettings>? HttpAction = null);

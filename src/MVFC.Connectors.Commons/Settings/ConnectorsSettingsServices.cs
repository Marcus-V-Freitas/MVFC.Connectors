namespace MVFC.Connectors.Commons.Settings;

public sealed record ConnectorsSettingsServices(
    RefitSettings RefitSettings,
    Action<HttpSettings>? HttpAction = null);

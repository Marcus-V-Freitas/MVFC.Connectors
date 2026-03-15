namespace MVFC.Connectors.Tests.Helpers;

public static class TestsHelpers
{
    public static T ObterApi<T>(Action<IServiceCollection> action) where T : IConnectorApi
    {
        ArgumentNullException.ThrowIfNull(action);

        var services = new ServiceCollection();
        action.Invoke(services);
        var provider = services.BuildServiceProvider();

        return provider.GetRequiredService<T>();
    }
}

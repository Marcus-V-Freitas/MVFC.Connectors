namespace MVFC.Connectors.Tests.Helpers;

public enum RegistrationMode
{
    Manual,
    ServiceCollection
}

public abstract class ConnectorTestsBase<T> where T : IConnectorApi
{
    protected abstract T ManualApi { get; }

    protected abstract T ServiceCollectionApi { get; }

    protected virtual async Task ValidarConfiguracaoApi(RegistrationMode mode)
    {
        var api = mode switch
        {
            RegistrationMode.Manual => ManualApi,
            RegistrationMode.ServiceCollection => ServiceCollectionApi,
            _ => throw new ArgumentOutOfRangeException(nameof(mode))
        };

        try
        {
            await ExecutarChamadaBasica(api).ConfigureAwait(false);
        }
        catch (Exception ex) when (IntegracaoExtensions.IsExcecaoIndisponivel(ex))
        {
            Assert.Skip($"{typeof(T).Name} está indisponível ou lento no momento. O teste foi ignorado.");
        }
    }

    protected abstract Task ExecutarChamadaBasica(T api);
}

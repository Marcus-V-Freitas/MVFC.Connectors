namespace MVFC.Connectors.Commons.Interfaces;

public interface ITokenProvider
{
    public string TipoDeToken => "Bearer";

    public Task<string> ObterTokenAsync(CancellationToken cancellationToken);

    public IDictionary<string, string> ObterAuthHeaders();
}

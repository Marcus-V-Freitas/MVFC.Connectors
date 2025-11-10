namespace MVFC.Connectors.Commons.Interfaces;

public interface ITokenProvider
{
    string TipoDeToken => "Bearer";

    Task<string> ObterTokenAsync(CancellationToken cancellationToken);
}
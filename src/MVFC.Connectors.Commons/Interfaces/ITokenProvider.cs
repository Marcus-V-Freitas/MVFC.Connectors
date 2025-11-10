namespace MVFC.Connectors.Commons.Interfaces;

public interface ITokenProvider
{
    string TokenType => "Bearer";

    Task<string> GetTokenAsync(CancellationToken cancellationToken);
}
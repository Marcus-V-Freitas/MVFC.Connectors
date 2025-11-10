namespace MVFC.Connectors.IA.Pollinations;

public interface ITextoPollinationsApi : IConnectorApi
{
    [Get("/{prompt}")]
    Task<ApiResponse<string>> GerarTextoAsync(string prompt);
}
namespace MVFC.Connectors.IA.Pollinations;

public interface ITextoPollinationsApi : IConnectorApi
{
    [Get("/{prompt}")]
    public Task<ApiResponse<string>> GerarTextoAsync(string prompt);
}

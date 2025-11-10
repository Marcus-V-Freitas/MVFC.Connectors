namespace MVFC.Connectors.IA.Pollinations;

public interface IImagemPollinationsApi : IConnectorApi
{

    [Get("/prompt/{prompt}")]
    Task<ApiResponse<Stream>> GerarImagemAsync(string prompt);
}
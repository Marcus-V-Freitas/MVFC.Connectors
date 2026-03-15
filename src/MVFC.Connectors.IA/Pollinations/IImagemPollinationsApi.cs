namespace MVFC.Connectors.IA.Pollinations;

public interface IImagemPollinationsApi : IConnectorApi
{
    [Get("/image/{prompt}?model=flux&width=1024&height=1024&seed=0&enhance=false")]
    public Task<ApiResponse<Stream>> GerarImagemAsync(string prompt);
}

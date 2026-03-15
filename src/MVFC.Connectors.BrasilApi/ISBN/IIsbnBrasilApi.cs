namespace MVFC.Connectors.BrasilApi.ISBN;

public interface IIsbnBrasilApi : IConnectorApi
{
    [Get("/isbn/v1/{isbn}")]
    public Task<ApiResponse<IsbnLivroDto>> ObterLivroPorIsbnAsync(string isbn);
}

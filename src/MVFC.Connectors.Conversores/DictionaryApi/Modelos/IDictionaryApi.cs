namespace MVFC.Connectors.Conversores.DictionaryApi.Modelos;

public interface IDictionaryApi : IConnectorApi
{
    [Get("/entries/en/{palavra}")]
    public Task<ApiResponse<IReadOnlyList<DictWordDto>>> ObterSignificadoPorPalavraAsync(string palavra);
}

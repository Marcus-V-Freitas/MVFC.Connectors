namespace MVFC.Connectors.Conversores.DictionaryApi.Modelos;

public interface IDictionaryApi : IConnectorApi
{
    [Get("/entries/en/{palavra}")]
    Task<ApiResponse<IReadOnlyList<DictWordDto>>> ObterSignificadoPorPalavraAsync(string palavra);
}
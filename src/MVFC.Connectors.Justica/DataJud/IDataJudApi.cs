namespace MVFC.Connectors.Justica.DataJud;

public interface IDataJudApi : IConnectorApi
{
    [Post("/{tribunal}/_search")]
    public Task<ApiResponse<DataJudResultadoDto>> ObterProcessosPorNumeroAsync(DataJudTribunal tribunal, [Body] DataJudProcessoRequest request);
}

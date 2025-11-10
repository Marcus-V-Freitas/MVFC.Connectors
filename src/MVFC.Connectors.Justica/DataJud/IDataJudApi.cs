namespace MVFC.Connectors.Justica.DataJud;

public interface IDataJudApi : IConnectorApi
{
    [Post("/{tribunal}/_search")]
    Task<ApiResponse<DataJudResultadoDto>> ObterProcessosPorNumeroAsync(DataJudTribunal tribunal, [Body] DataJudProcessoRequest request);
}
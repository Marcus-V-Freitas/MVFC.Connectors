namespace MVFC.Connectors.BancoData.Tratado;

public interface IBancoDataTratadoApi : IConnectorApi
{
    [Get("/{bankCode}")]
    Task<ApiResponse<BancoTratadoDto>> ObterDadosTratadosAsync(string bankCode);
}
namespace MVFC.Connectors.BancoData.Tratado;

public interface IBancoDataTratadoApi : IConnectorApi
{
    [Get("/{bankCode}")]
    public Task<ApiResponse<BancoTratadoDto>> ObterDadosTratadosAsync(string bankCode);
}

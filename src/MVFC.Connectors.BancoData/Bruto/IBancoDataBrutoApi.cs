namespace MVFC.Connectors.BancoData.Bruto;

public interface IBancoDataBrutoApi : IConnectorApi
{
    [Get("/{bankCode}")]
    public Task<ApiResponse<BancoBrutoDto>> ObterDadosBrutosAsync(string bankCode);
}

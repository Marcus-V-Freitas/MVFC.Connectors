namespace MVFC.Connectors.BancoData.Bruto;

public interface IBancoDataBrutoApi : IConnectorApi
{
    [Get("/{bankCode}")]
    Task<ApiResponse<BancoBrutoDto>> ObterDadosBrutosAsync(string bankCode);
}
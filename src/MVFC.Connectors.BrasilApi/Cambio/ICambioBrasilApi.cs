namespace MVFC.Connectors.BrasilApi.Cambio;

public interface ICambioBrasilApi : IConnectorApi
{
    [Get("/cambio/v1/moedas")]
    public Task<ApiResponse<IReadOnlyList<CambioDto>>> ObterCambiosAsync();

    [Get("/cambio/v1/cotacao/{moeda}/{data}")]
    public Task<ApiResponse<CotacaoMoedaDto>> ObterCambioPorMoedaEDataAsync(string moeda, string data);
}

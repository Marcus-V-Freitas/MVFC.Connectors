namespace MVFC.Connectors.BrasilApi.Cambio;

public interface ICambioBrasilApi : IConnectorApi
{
    [Get("/cambio/v1/moedas")]
    Task<ApiResponse<IReadOnlyList<CambioDto>>> GetCurrenciesAsync();

    [Get("/cambio/v1/cotacao/{moeda}/{data}")]
    Task<ApiResponse<CotacaoMoedaDto>> GetCurrencyQuotationByDateAsync(string moeda, string data);
}
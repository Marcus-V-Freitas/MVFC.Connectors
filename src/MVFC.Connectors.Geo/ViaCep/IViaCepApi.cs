namespace MVFC.Connectors.Geo.ViaCep;

public interface IViaCepApi : IConnectorApi
{
    [Get("/ws/{cep}/json/")]
    Task<ApiResponse<ViaCepDto>> ObterDadosPorCepAsync(string cep);
}
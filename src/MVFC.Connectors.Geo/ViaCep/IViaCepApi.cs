namespace MVFC.Connectors.Geo.ViaCep;

public interface IViaCepApi : IConnectorApi
{
    [Get("/ws/{cep}/json/")]
    public Task<ApiResponse<ViaCepDto>> ObterDadosPorCepAsync(string cep);
}

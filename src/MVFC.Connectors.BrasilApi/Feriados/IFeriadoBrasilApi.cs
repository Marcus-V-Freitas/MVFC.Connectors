namespace MVFC.Connectors.BrasilApi.Feriados;

public interface IFeriadoBrasilApi : IConnectorApi
{
    [Get("/feriados/v1/{ano}")]
    public Task<ApiResponse<IReadOnlyList<FeriadoDto>>> ObterFeriadosPorAnoAsync(int ano);
}

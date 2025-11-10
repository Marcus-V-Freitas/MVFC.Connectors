namespace MVFC.Connectors.BrasilApi.Feriados;

public interface IFeriadoBrasilApi : IConnectorApi
{
    [Get("/feriados/v1/{ano}")]
    Task<ApiResponse<IReadOnlyList<FeriadoDto>>> GetFeriadosByAnoAsync(int ano);
}
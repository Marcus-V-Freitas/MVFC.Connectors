namespace MVFC.Connectors.BrasilApi.CPTEC;

public interface ICptecBrasilApi : IConnectorApi
{
    [Get("/cptec/v1/cidade")]
    Task<ApiResponse<IReadOnlyList<CptecCidadeDto>>> ObterCidadesAsync();

    [Get("/cptec/v1/cidade/{nomeDaCidade}")]
    Task<ApiResponse<IReadOnlyList<CptecCidadeDto>>> ObterCidadesPorNomeAsync(string nomeDaCidade);

    [Get("/cptec/v1/clima/aeroporto/{codigoClima}")]
    Task<ApiResponse<CptecClimaDto>> ObterClimaPorCodigoAsync(string codigoClima);

    [Get("/cptec/v1/clima/previsao/{codigoDaCidade}")]
    Task<ApiResponse<CptecPrevisaoDto<CptecClimaCidadeDto>>> ObterPrevisaoPorCodigoDaCidadeAsync(int codigoDaCidade);

    [Get("/cptec/v1/clima/previsao/{codigoDaCidade}/{dias}")]
    Task<ApiResponse<CptecPrevisaoDto<CptecClimaCidadeDto>>> ObterPrevisaoPorCodigoDaCidadeEDiasAsync(int codigoDaCidade, int dias);

    [Get("/cptec/v1/ondas/{codigoDaCidade}")]
    Task<ApiResponse<CptecPrevisaoDto<CptecOndaCidadeDto>>> ObterOndasPorCodigoDaCidadeAsync(int codigoDaCidade);

    [Get("/cptec/v1/ondas/{codigoDaCidade}/{dias}")]
    Task<ApiResponse<CptecPrevisaoDto<CptecOndaCidadeDto>>> ObterOndasPorCodigoDaCidadeEDiasAsync(int codigoDaCidade, int dias);
}
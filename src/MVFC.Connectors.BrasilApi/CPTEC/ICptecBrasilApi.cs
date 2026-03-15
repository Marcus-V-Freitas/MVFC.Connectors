namespace MVFC.Connectors.BrasilApi.CPTEC;

public interface ICptecBrasilApi : IConnectorApi
{
    [Get("/cptec/v1/cidade")]
    public Task<ApiResponse<IReadOnlyList<CptecCidadeDto>>> ObterCidadesAsync();

    [Get("/cptec/v1/cidade/{nomeDaCidade}")]
    public Task<ApiResponse<IReadOnlyList<CptecCidadeDto>>> ObterCidadesPorNomeAsync(string nomeDaCidade);

    [Get("/cptec/v1/clima/aeroporto/{codigoClima}")]
    public Task<ApiResponse<CptecClimaDto>> ObterClimaPorCodigoAsync(string codigoClima);

    [Get("/cptec/v1/clima/previsao/{codigoDaCidade}")]
    public Task<ApiResponse<CptecPrevisaoDto<CptecClimaCidadeDto>>> ObterPrevisaoPorCodigoDaCidadeAsync(int codigoDaCidade);

    [Get("/cptec/v1/clima/previsao/{codigoDaCidade}/{dias}")]
    public Task<ApiResponse<CptecPrevisaoDto<CptecClimaCidadeDto>>> ObterPrevisaoPorCodigoDaCidadeEDiasAsync(int codigoDaCidade, int dias);

    [Get("/cptec/v1/ondas/{codigoDaCidade}")]
    public Task<ApiResponse<CptecPrevisaoDto<CptecOndaCidadeDto>>> ObterOndasPorCodigoDaCidadeAsync(int codigoDaCidade);

    [Get("/cptec/v1/ondas/{codigoDaCidade}/{dias}")]
    public Task<ApiResponse<CptecPrevisaoDto<CptecOndaCidadeDto>>> ObterOndasPorCodigoDaCidadeEDiasAsync(int codigoDaCidade, int dias);
}

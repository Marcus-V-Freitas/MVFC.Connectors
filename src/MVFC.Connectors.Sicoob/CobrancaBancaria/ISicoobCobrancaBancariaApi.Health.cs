namespace MVFC.Connectors.Sicoob.CobrancaBancaria;

public partial interface ISicoobCobrancaBancariaApi
{
    [Get("/health")]
    public Task<ApiResponse<HealthResponse>> VerificarSaudeAsync();
}

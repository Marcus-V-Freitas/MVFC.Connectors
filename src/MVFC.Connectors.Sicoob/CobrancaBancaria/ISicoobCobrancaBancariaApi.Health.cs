namespace MVFC.Connectors.Sicoob.CobrancaBancaria;

public partial interface ISicoobCobrancaBancariaApi
{
    [Get("/health")]
    Task<ApiResponse<HealthResponse>> VerificarSaudeAsync();
}
namespace MVFC.Connectors.Sicoob.CobrancaBancaria;

public partial interface ISicoobCobrancaBancariaApi
{
    [Post("/boletos")]
    public Task<ApiResponse<SicoobResponse<BoletoResponse>>> IncluirBoletoAsync([Body] BoletoRequest request);

    [Get("/boletos")]
    public Task<ApiResponse<SicoobResponse<BoletoConsultaResponse>>> ConsultarBoletoAsync([Query] BoletoConsultaQuery query);

    [Get("/pagadores/{numeroCpfCnpj}/boletos")]
    public Task<ApiResponse<SicoobResponse<BoletoConsultaResponse[]>>> ListarBoletosPorPagadorAsync(string numeroCpfCnpj, [Query] BoletoConsultarPagadorQuery query);

    [Get("/boletos/segunda-via")]
    public Task<ApiResponse<SicoobResponse<BoletoResponse>>> EmitirSegundaViaAsync([Query] BoletoSegundaViaQuery query);

    [Get("/boletos/faixas-nosso-numero")]
    public Task<ApiResponse<SicoobResponse<FaixaNossoNumeroResponse[]>>> ConsultarFaixasNossoNumeroAsync([Query] BoletoConsultarFaixaQuery query);

    [Patch("/boletos/{nossoNumero}")]
    public Task<ApiResponse<string>> AlterarBoletoAsync(int nossoNumero, [Body] BoletoAlteracaoRequest request);

    [Post("/boletos/{nossoNumero}/baixar")]
    public Task<ApiResponse<string>> BaixarBoletoAsync(int nossoNumero, [Body] BoletoBaixaRequest request);
}

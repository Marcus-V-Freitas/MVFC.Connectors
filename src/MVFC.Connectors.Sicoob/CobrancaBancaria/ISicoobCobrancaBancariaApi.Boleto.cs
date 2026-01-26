namespace MVFC.Connectors.Sicoob.CobrancaBancaria;

public partial interface ISicoobCobrancaBancariaApi
{
    [Post("/boletos")]
    Task<ApiResponse<SicoobResponse<BoletoResponse>>> IncluirBoletoAsync([Body] BoletoRequest request);

    [Get("/boletos")]
    Task<ApiResponse<SicoobResponse<BoletoConsultaResponse>>> ConsultarBoletoAsync([Query] BoletoConsultaQuery query);

    [Get("/pagadores/{numeroCpfCnpj}/boletos")]
    Task<ApiResponse<SicoobResponse<BoletoConsultaResponse[]>>> ListarBoletosPorPagadorAsync(string numeroCpfCnpj, [Query] BoletoConsultarPagadorQuery query);

    [Get("/boletos/segunda-via")]
    Task<ApiResponse<SicoobResponse<BoletoResponse>>> EmitirSegundaViaAsync([Query] BoletoSegundaViaQuery query);

    [Get("/boletos/faixas-nosso-numero")]
    Task<ApiResponse<SicoobResponse<FaixaNossoNumeroResponse[]>>> ConsultarFaixasNossoNumeroAsync([Query] BoletoConsultarFaixaQuery query);

    [Patch("/boletos/{nossoNumero}")]
    Task<ApiResponse<string>> AlterarBoletoAsync(int nossoNumero, [Body] BoletoAlteracaoRequest request);

    [Post("/boletos/{nossoNumero}/baixar")]
    Task<ApiResponse<string>> BaixarBoletoAsync(int nossoNumero, [Body] BoletoBaixaRequest request);
}
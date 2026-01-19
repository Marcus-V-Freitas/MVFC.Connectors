namespace MVFC.Connectors.Financas.Bcb;

public interface IBcbInstituicaoApi : IConnectorApi
{
    [Post("/informes/rest/pessoasJuridicas")]
    Task<ApiResponse<BcbInstituicaoResponse>> ObterInstituicoesReguladasAsync([Body] BcbInstituicaoRequest request);

    [Get("/informes/rest/pessoasJuridicas")]
    Task<ApiResponse<BcbInstituicaoDto>> ObterInstituicaoPorCnpj([Query] string cnpj);

    [Post("/informes/rest/pessoasJuridicas/participantesPix")]
    Task<ApiResponse<BcbInstituicaoResponse>> ObterInstituicoesParticipantesDoPixAsync([Body] BcbParticipanteDoPixRequest request);    

    [Post("/informes/rest/conglomerados")]
    Task<ApiResponse<BcbConglomeradoResponse>> ObterConglomeradosAsync([Body] BcbInstituicaoRequest request);

    [Get("/informes/rest/conglomerados/{codigo}")]
    Task<ApiResponse<BcbConglomeradoDto>> ObterConglomeradoPorCodigoAsync(string codigo);

    [Post("/informes/rest/agencia")]
    Task<ApiResponse<BcbAgenciaResponse>> ObterAgenciaAsync([Body] BcbAgenciaRequest request);

    [Get("/informes/rest/balanco/arquivosCosif")]
    Task<ApiResponse<IReadOnlyList<BcbDocumentoDto>>> ObterDocumentosContabeisAsync([Query] string anoMes, [Query] string cnpj, [Query] int periodo);

    [Get("/informes/rest/balanco")]
    Task<ApiResponse<IReadOnlyList<BcbDocumentoDto>>> ObterBalancosAsync([Query] string anoMes, [Query] string cnpj, [Query] int periodo);

    [Get("/informes/rest/segmentos")]
    Task<ApiResponse<IReadOnlyList<BcbSegmentoDto>>> ObterSegmentosAsync();

    [Get("/informes/rest/estados")]
    Task<ApiResponse<IReadOnlyList<BcbEstadoDto>>> ObterEstadosAsync();

    [Get("/informes/rest/municipios")]
    Task<ApiResponse<IReadOnlyList<BcbMunicipioDto>>> ObterMunicipiosAsync();

    [Get("/informes/rest/paises")]
    Task<ApiResponse<IReadOnlyList<string>>> ObterPaisesAsync();
}
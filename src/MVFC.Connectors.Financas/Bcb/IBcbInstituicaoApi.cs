namespace MVFC.Connectors.Financas.Bcb;

public interface IBcbInstituicaoApi : IConnectorApi
{
    [Post("/informes/rest/pessoasJuridicas")]
    public Task<ApiResponse<BcbInstituicaoResponse>> ObterInstituicoesReguladasAsync([Body] BcbInstituicaoRequest request);

    [Get("/informes/rest/pessoasJuridicas")]
    public Task<ApiResponse<BcbInstituicaoDto>> ObterInstituicaoPorCnpj([Query] string cnpj);

    [Post("/informes/rest/pessoasJuridicas/participantesPix")]
    public Task<ApiResponse<BcbInstituicaoResponse>> ObterInstituicoesParticipantesDoPixAsync([Body] BcbParticipanteDoPixRequest request);    

    [Post("/informes/rest/conglomerados")]
    public Task<ApiResponse<BcbConglomeradoResponse>> ObterConglomeradosAsync([Body] BcbInstituicaoRequest request);

    [Get("/informes/rest/conglomerados/{codigo}")]
    public Task<ApiResponse<BcbConglomeradoDto>> ObterConglomeradoPorCodigoAsync(string codigo);

    [Post("/informes/rest/agencia")]
    public Task<ApiResponse<BcbAgenciaResponse>> ObterAgenciaAsync([Body] BcbAgenciaRequest request);

    [Get("/informes/rest/balanco/arquivosCosif")]
    public Task<ApiResponse<IReadOnlyList<BcbDocumentoDto>>> ObterDocumentosContabeisAsync([Query] string anoMes, [Query] string cnpj, [Query] int periodo);

    [Get("/informes/rest/balanco")]
    public Task<ApiResponse<IReadOnlyList<BcbDocumentoDto>>> ObterBalancosAsync([Query] string anoMes, [Query] string cnpj, [Query] int periodo);

    [Get("/informes/rest/segmentos")]
    public Task<ApiResponse<IReadOnlyList<BcbSegmentoDto>>> ObterSegmentosAsync();

    [Get("/informes/rest/estados")]
    public Task<ApiResponse<IReadOnlyList<BcbEstadoDto>>> ObterEstadosAsync();

    [Get("/informes/rest/municipios")]
    public Task<ApiResponse<IReadOnlyList<BcbMunicipioDto>>> ObterMunicipiosAsync();

    [Get("/informes/rest/paises")]
    public Task<ApiResponse<IReadOnlyList<string>>> ObterPaisesAsync();
}

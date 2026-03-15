namespace MVFC.Connectors.Educacao.Hipolabs;

public interface IHipolabsApi : IConnectorApi
{
    [Get("/search")]
    public Task<ApiResponse<IReadOnlyList<HipolabsDto>>> ObterUniversidadesPorPaisAsync([AliasAs("country")] string pais);
}

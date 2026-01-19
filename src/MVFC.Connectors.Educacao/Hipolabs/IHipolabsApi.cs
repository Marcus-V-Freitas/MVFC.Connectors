namespace MVFC.Connectors.Educacao.Hipolabs;

public interface IHipolabsApi : IConnectorApi
{
    [Get("/search")]
    Task<ApiResponse<IReadOnlyList<HipolabsDto>>> ObterUniversidadesPorPaisAsync([AliasAs("country")] string pais);
}
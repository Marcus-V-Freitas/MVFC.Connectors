namespace MVFC.Connectors.Developer.DaliboExplain.Extensoes;

public static class DaliboExtensoesExplain
{
    private const string URL_BASE = "https://explain.dalibo.com";

    public static IDaliboExplainApi ObterDaliboExplainApi() =>
         ExtensoesBase.ObterApi<IDaliboExplainApi>(URL_BASE).Construir();

    public static void AddDaliboExplain(this IServiceCollection services) =>
        services.AddApi<IDaliboExplainApi>(URL_BASE);
}

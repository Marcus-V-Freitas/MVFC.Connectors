namespace MVFC.Connectors.Developer.MysqlExplain.Extensoes;

public static class MysqlExplainExtensoes
{
    private const string URL_BASE = "https://api.mysqlexplain.com/v2";

    public static IMysqlExplainApi ObterMysqlExplainApi() =>
         ExtensoesBase.ObterApi<IMysqlExplainApi>(URL_BASE).Construir();

    public static void AddMysqlExplain(this IServiceCollection services) =>
        services.AddApi<IMysqlExplainApi>(URL_BASE);
}
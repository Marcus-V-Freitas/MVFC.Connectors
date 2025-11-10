namespace MVFC.Connectors.Justica.DataJud.Extensoes;

public static class DataJudExtensoes
{
    private const string URL_BASE = "https://api-publica.datajud.cnj.jus.br";

    public static IDataJudApi ObterDataJudApi() =>
         ExtensoesBase.ObterApi<IDataJudApi>(URL_BASE)
                      .AdicionarHandler(new AuthTokenHandler(new DataJudAuthProvider()))
                      .Construir();

    public static void AddDataJud(this IServiceCollection services) =>
        services.AddApi<IDataJudApi>(URL_BASE, (_, s) =>
        {
            s.AddSingleton<ITokenProvider, DataJudAuthProvider>();
            s.AddTransient<AuthTokenHandler>();
        }).AddHttpMessageHandler<AuthTokenHandler>();
}
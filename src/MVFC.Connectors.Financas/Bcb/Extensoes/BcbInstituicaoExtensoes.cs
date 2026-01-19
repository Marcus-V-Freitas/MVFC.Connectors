namespace MVFC.Connectors.Financas.Bcb.Extensoes;

public static class BcbInstituicaoExtensoes
{
    private const string URL_BASE = "https://www3.bcb.gov.br";

    public static IBcbInstituicaoApi ObterBcbInstituicaoApi() =>
         ExtensoesBase.ObterApi<IBcbInstituicaoApi>(URL_BASE).Construir();

    public static void AddBcbInstituicao(this IServiceCollection services) =>
        services.AddApi<IBcbInstituicaoApi>(URL_BASE);
}
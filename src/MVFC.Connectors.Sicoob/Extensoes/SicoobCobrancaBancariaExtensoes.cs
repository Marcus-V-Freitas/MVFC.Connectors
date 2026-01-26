namespace MVFC.Connectors.Sicoob.Extensoes;

public static class SicoobCobrancaBancariaExtensoes
{
    private static readonly Dictionary<bool, string> _urlsBase = new()
    {
        { false, "https://api.sicoob.com.br/cobranca-bancaria/v3" },
        { true,  "https://sandbox.sicoob.com.br/sicoob/sandbox/cobranca-bancaria/v3" }
    };

    public static ISicoobCobrancaBancariaApi ObterSicoobCobrancaBancariaApi(SicoobConfig config) =>
         SicoobExtensoes.ObterSicoobApi<ISicoobCobrancaBancariaApi>(_urlsBase, config);

    public static void AddSicoobCobrancaBancaria(this IServiceCollection services, SicoobConfig config) =>
        SicoobExtensoes.AddSicoob<ISicoobCobrancaBancariaApi>(services, _urlsBase, config);
}
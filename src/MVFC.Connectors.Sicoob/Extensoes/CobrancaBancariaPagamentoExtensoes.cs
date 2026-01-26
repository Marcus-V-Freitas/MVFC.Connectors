namespace MVFC.Connectors.Sicoob.Extensoes;

public static class SicoobCobrancaBancariaPagamentoExtensoes
{
    private static readonly Dictionary<bool, string> _urlsBase = new()
    {
        { false, "https://api.sicoob.com.br/pagamentos/v3" },
        { true,  "https://sandbox.sicoob.com.br/sicoob/sandbox/cobranca-bancaria-pagamentos/v3" }
    };

    public static ISicoobCobrancaBancariaPagamentoApi ObterSicoobCobrancaBancariaPagamentoApi(SicoobConfig config) =>
         SicoobExtensoes.ObterSicoobApi<ISicoobCobrancaBancariaPagamentoApi>(_urlsBase, config);

    public static void AddSicoobCobrancaBancariaPagamento(this IServiceCollection services, SicoobConfig config) =>
        SicoobExtensoes.AddSicoob<ISicoobCobrancaBancariaPagamentoApi>(services, _urlsBase, config);
}
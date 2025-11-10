namespace MVFC.Connectors.Commons.Providers;

internal sealed class RandomUserAgentProvider : IUserAgentProvider
{
    private static readonly string[] Browsers =
    [
        "Chrome", "Firefox", "Safari", "Edge",
    ];

    private static readonly string[] Plataformas =
    [
        "Windows NT 10.0; Win64; x64",
        "Windows NT 6.1; Win64; x64",
        "Macintosh; Intel Mac OS X 10_15_7",
        "X11; Linux x86_64",
    ];

    public string ObterUserAgent()
    {
        ComBrowserAleatorio(out var browser);
        ComPlataformaAleatoria(out var plataforma);
        ComVersaoAleatoria(out var versaoMaior, out var versaoMenor, out var construcao);

        return ConstruirUserAgent(browser, plataforma, versaoMaior, versaoMenor, construcao);
    }

    private static void ComBrowserAleatorio(out string browser) =>
        browser = Browsers[Random.Shared.Next(Browsers.Length)];

    private static void ComPlataformaAleatoria(out string plataforma) =>
        plataforma = Plataformas[Random.Shared.Next(Plataformas.Length)];

    private static void ComVersaoAleatoria(out int versaoMaior, out int versaoMenor, out int construcao)
    {
        versaoMaior = Random.Shared.Next(80, 120);
        versaoMenor = Random.Shared.Next(0, 4000);
        construcao = Random.Shared.Next(0, 100);
    }

    private static string ConstruirUserAgent(string browser, string plataforma, int versaoMaior, int versaoMenor, int construcao)
    {
        var versaoCompleta = $"{versaoMaior}.{versaoMenor}.{construcao}";

        return browser switch
        {
            "Chrome" => $"Mozilla/5.0 ({plataforma}) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/{versaoCompleta} Safari/537.36",
            "Firefox" => $"Mozilla/5.0 ({plataforma}; rv:{versaoMaior}.0) Gecko/20100101 Firefox/{versaoMaior}.0",
            "Safari" => $"Mozilla/5.0 ({plataforma}) AppleWebKit/605.1.15 (KHTML, like Gecko) Version/{versaoMaior}.0 Safari/605.1.15",
            "Edge" => $"Mozilla/5.0 ({plataforma}) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/{versaoCompleta} Safari/537.36 Edg/{versaoMaior}.{Random.Shared.Next(0, 2000)}",
            _ => $"{Guid.NewGuid()}/1.0 ({plataforma})"
        };
    }
}
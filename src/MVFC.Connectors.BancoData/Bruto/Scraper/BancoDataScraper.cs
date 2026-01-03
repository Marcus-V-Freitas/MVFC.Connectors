namespace MVFC.Connectors.BancoData.Bruto.Scraper;

internal sealed partial class BancoDataScraper : IBancoDataScraper, IDisposable
{
    private readonly IBrowsingContext _context = BrowsingContext.New(Configuration.Default);

    public async Task<BancoBrutoDto> ScrapeAsync(string bankCode, string html)
    {
        var documento = await _context.OpenAsync(req => req.Content(html));

        return ExtrairDadosBrutos(documento, bankCode);
    }

    private static BancoBrutoDto ExtrairDadosBrutos(IDocument documento, string bankCode)
    {
        var tabelas = documento.QuerySelectorAll("table").ToList();

        if (tabelas.Count < 10)
            throw new ScraperException($"Esperada pelo menos 10 tabelas, encontradas {tabelas.Count}");

        var nome = ExtrairNome(documento);
        var infoBasica = ExtrairResultadosAnuais(tabelas[0]);
        var resultados = ExtractResultadosAnuais(tabelas[1]);
        var indicadores = ExtrairIndicadores(tabelas[2]);
        var dre = ExtrairDRE(tabelas[3]);
        var balanco = ExtrairBalanco(tabelas[4]);
        var redeAtendimento = ExtrairRede(tabelas[9]);

        return new BancoBrutoDto(
            nome,
            bankCode,
            infoBasica,
            redeAtendimento,
            resultados,
            indicadores,
            dre,
            balanco);
    }

    private static string ExtrairNome(IDocument documento)
    {
        var titulo = documento.QuerySelector("title")?.TextContent ?? "";
        var match = RegexExtensoes.BancoRegex().Match(titulo);
        
        return match.Success ? 
                match.Groups[1].Value.Trim() : 
                titulo.Split('-').FirstOrDefault()?.Trim() ?? "Desconhecido";
    }

    private static InfoBasicaBrutoDto ExtrairResultadosAnuais(IElement tabela)
    {
        var linhas = tabela.QuerySelectorAll("tr").ToList();

        return new InfoBasicaBrutoDto(
            ExtrairValorDaCelula(linhas, 0, 1),
            ExtrairValorDaCelula(linhas, 1, 1),
            ExtrairValorDaCelula(linhas, 2, 1),
            ExtrairValorDaCelula(linhas, 3, 1),
            ExtrairValorDaCelula(linhas, 4, 1),
            ExtrairValorDaCelula(linhas, 5, 1),
            ExtrairValorDaCelula(linhas, 6, 1),
            ExtrairValorDaCelula(linhas, 7, 1),
            ExtrairValorDaCelula(linhas, 8, 1));
    }

    private static RedeAtendimentoBrutoDto ExtrairRede(IElement tabela)
    {
        var linhas = tabela.QuerySelectorAll("tr").ToList();

        return linhas.Count < 2
            ? new RedeAtendimentoBrutoDto("", "0", "-")
            : new RedeAtendimentoBrutoDto(
            ExtrairValorDaCelula(linhas, 1, 0),
            ExtrairValorDaCelula(linhas, 1, 1),
            ExtrairValorDaCelula(linhas, 1, 2));
    }

    private static List<ResultadoAnualBrutoDto> ExtractResultadosAnuais(IElement tabela)
    {
        var linhas = tabela.QuerySelectorAll("tr").Skip(1).ToList();
        var resultados = new List<ResultadoAnualBrutoDto>();

        foreach (var linha in linhas)
        {
            var celulas = linha.QuerySelectorAll("td").ToList();

            if (celulas.Count >= 3)
            {
                resultados.Add(new ResultadoAnualBrutoDto(
                    LimparTexto(celulas[0].TextContent),
                    LimparTexto(celulas[1].TextContent),
                    LimparTexto(celulas[2].TextContent)));
            }
        }

        return resultados;
    }

    private static IndicadoresBrutoDto ExtrairIndicadores(IElement tabela)
    {
        var linhas = tabela.QuerySelectorAll("tr").ToList();

        return new IndicadoresBrutoDto(
            ExtrairValorDaCelula(linhas, 0, 1),
            ExtrairValorDaCelula(linhas, 1, 1),
            ExtrairValorDaCelula(linhas, 2, 1));
    }

    private static DemonstrativoBrutoDto ExtrairDRE(IElement tabela)
    {
        var linhas = tabela.QuerySelectorAll("tr").ToList();

        return new DemonstrativoBrutoDto(
            ExtrairValorDaCelula(linhas, 0, 1),
            ExtrairValorDaCelula(linhas, 1, 1),
            ExtrairValorDaCelula(linhas, 2, 1));
    }

    private static BalancoBrutoDto ExtrairBalanco(IElement tabela)
    {
        var linhas = tabela.QuerySelectorAll("tr").ToList();

        return new BalancoBrutoDto(
            ExtrairValorDaCelula(linhas, 0, 1),
            ExtrairValorDaCelula(linhas, 1, 1),
            ExtrairValorDaCelula(linhas, 2, 1));
    }

    private static string ExtrairValorDaCelula(List<IElement> linhas, int indexLinha, int indexCelula)
    {
        if (indexLinha >= linhas.Count) 
            return string.Empty;

        var celulas = linhas[indexLinha].QuerySelectorAll("td, th").ToList();

        return indexCelula >= celulas.Count ? 
            string.Empty : 
            LimparTexto(celulas[indexCelula].TextContent);
    }

    private static string LimparTexto(string texto) =>
        RegexExtensoes.TextoLimpoRegex().Replace(texto, " ").Trim();

    public void Dispose() =>
        _context?.Dispose();
}
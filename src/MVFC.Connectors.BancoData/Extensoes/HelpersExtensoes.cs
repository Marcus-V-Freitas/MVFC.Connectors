namespace MVFC.Connectors.BancoData.Extensoes;

internal static class HelpersExtensoes
{
    private static readonly Dictionary<string, int> _meses = new()
    {
        {"janeiro", 1}, {"fevereiro", 2}, {"março", 3}, {"abril", 4},
        {"maio", 5}, {"junho", 6}, {"julho", 7}, {"agosto", 8},
        {"setembro", 9}, {"outubro", 10}, {"novembro", 11}, {"dezembro", 12}
    };

    internal static string ExtrairBankCode(string? caminho)
    {
        if (string.IsNullOrEmpty(caminho))
            return string.Empty;

        var partes = caminho.Split('/', StringSplitOptions.RemoveEmptyEntries);
        return partes.Length >= 2 ? partes[1] : string.Empty;
    }

    internal static (string cidade, string estado) ExtrairMatriz(string matriz)
    {
        var partes = matriz.Split('-');
        if (partes.Length == 2)
            return (partes[0].Trim(), partes[1].Trim());

        return (matriz, "");
    }

    internal static string ExtrairCnpjNumerico(string cnpj) =>
        RegexExtensoes.CnpjRegex().Replace(cnpj, "");

    internal static int CalcularAnosDeOperacao(DateTime dataAbertura) =>
        dataAbertura == DateTime.MinValue ? 0 : (DateTime.Now.Year - dataAbertura.Year);

    internal static TipoControle ClassificarControleAcionario(string controle)
    {
        if (controle.Contains("estrangeiro", StringComparison.OrdinalIgnoreCase))
            return TipoControle.PrivadoEstrangeiro;
        if (controle.Contains("privado", StringComparison.OrdinalIgnoreCase))
            return TipoControle.PrivadoNacional;
        if (controle.Contains("público federal", StringComparison.OrdinalIgnoreCase) || controle.Contains("federal", StringComparison.OrdinalIgnoreCase))
            return TipoControle.PublicoFederal;
        if (controle.Contains("público estadual", StringComparison.OrdinalIgnoreCase) || controle.Contains("estadual", StringComparison.OrdinalIgnoreCase))
            return TipoControle.PublicoEstadual;
        if (controle.Contains("cooperativ", StringComparison.OrdinalIgnoreCase))
            return TipoControle.Cooperativo;

        // Default case
        return TipoControle.Outros;
    }

    internal static (int ano, bool parcial) ExtrairAno(string texto)
    {
        var match = RegexExtensoes.AnoRegex().Match(texto);
        var ano = match.Success ? int.Parse(match.Groups[1].Value) : 0;
        var parcial = texto.Contains("parcial", StringComparison.OrdinalIgnoreCase);

        return (ano, parcial);
    }

    internal static SituacaoImobilizacao ClassificarSituacaoImobilizacao(decimal indice)
    {
        if (indice <= 50.0m)
            return SituacaoImobilizacao.Adequado;

        // Default case
        return indice <= 60.0m ? SituacaoImobilizacao.Atencao : SituacaoImobilizacao.Critico;
    }

    internal static SituacaoBasileia ClassificarSituacaoBasileia(decimal indice)
    {
        if (indice >= 11.0m)
            return SituacaoBasileia.Adequado;

        // Default case
        return indice >= 8.5m ? SituacaoBasileia.Atencao : SituacaoBasileia.Critico;
    }

    internal static (int ano, int trimestre) ExtractTrimestreInfo(string text)
    {
        var match = RegexExtensoes.TrimestreRegex().Match(text);
        if (!match.Success)
            return (0, 0);

        var trimestre = int.Parse(match.Groups[1].Value);
        var ano = int.Parse(match.Groups[2].Value);
        return (ano, trimestre);
    }

    internal static DateTime ExtrairDataDoTexto(string texto)
    {
        return DateTime.TryParseExact(texto, "dd/MM/yyyy",
            CultureInfo.InvariantCulture, DateTimeStyles.None, out var data)
            ? data
            : DateTime.MinValue;
    }

    internal static int ExtrairValorInteiro(string texto)
    {
        var match = RegexExtensoes.ValoresInteiroRegex().Match(texto);
        return match.Success && int.TryParse(match.Value, out var valor) ? valor : 0;
    }

    internal static decimal CalcularPercentual(decimal resultado, decimal lucro) =>
        Math.Round(resultado != 0 ? (lucro / resultado) * 100 : 0, 2);

    internal static decimal ExtrairValorMonetario(string texto)
    {
        var match = RegexExtensoes.ValorMonetarioRegex().Match(texto);
        if (!match.Success) return 0m;

        var textoNumerico = match.Groups[1].Value.Replace(",", ".");

        if (!decimal.TryParse(textoNumerico, NumberStyles.Any, CultureInfo.InvariantCulture, out var valor))
            return 0m;

        if (texto.Contains("milhões", StringComparison.OrdinalIgnoreCase) ||
            texto.Contains("milhão", StringComparison.OrdinalIgnoreCase))
            valor *= 1_000_000;
        else if (texto.Contains("bilhões", StringComparison.OrdinalIgnoreCase) ||
                 texto.Contains("bilhão", StringComparison.OrdinalIgnoreCase))
            valor *= 1_000_000_000;
        else if (texto.Contains("mil", StringComparison.OrdinalIgnoreCase))
            valor *= 1_000;

        return valor;
    }

    internal static decimal ExtrairValorMonetarioAbsoluto(string texto) =>
        Math.Abs(ExtrairValorMonetario(texto));

    internal static decimal ExtrairPercentual(string texto)
    {
        var match = RegexExtensoes.PercentualRegex().Match(texto);

        if (!match.Success) 
            return 0m;

        var textoNumerico = match.Groups[1].Value.Replace(",", ".");
        decimal.TryParse(textoNumerico, NumberStyles.Any, CultureInfo.InvariantCulture, out var valor);
        return valor;
    }

    internal static DateTime ExtrairMesDoAno(string texto)
    {
        var match = RegexExtensoes.MesRegex().Match(texto);

        if (!match.Success)
            return DateTime.Now;

        var nomeDoMes = match.Groups[1].Value;
        var ano = int.Parse(match.Groups[2].Value);

        return _meses.TryGetValue(nomeDoMes.ToLower(), out var mes)
            ? new DateTime(ano, mes, 1, 0, 0, 0, DateTimeKind.Unspecified)
            : DateTime.Now;
    }

    internal static DateTime ExtrairTrimestre(string texto)
    {
        var match = RegexExtensoes.TrimestreRegex().Match(texto);

        if (!match.Success)
            return DateTime.Now;

        var trimestre = int.Parse(match.Groups[1].Value);
        var ano = int.Parse(match.Groups[2].Value);
        var mes = (trimestre - 1) * 3 + 3;

        return new DateTime(ano, mes, 1, 0, 0, 0, DateTimeKind.Unspecified);
    }
}
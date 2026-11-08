namespace MVFC.Connectors.BancoData.Extensoes;

internal static partial class RegexExtensoes
{
    [GeneratedRegex(@"(\d{4})", RegexOptions.None, matchTimeoutMilliseconds: 2000)]
    internal static partial Regex AnoRegex();

    [GeneratedRegex(@"(\d)T(\d{4})", RegexOptions.None, matchTimeoutMilliseconds: 2000)]
    internal static partial Regex TrimestreRegex();

    [GeneratedRegex(@"(-?\d+(?:,\d+)?)", RegexOptions.None, matchTimeoutMilliseconds: 2000)]
    internal static partial Regex ValorMonetarioRegex();

    [GeneratedRegex(@"(\w+)\s+de\s+(\d{4})", RegexOptions.None, matchTimeoutMilliseconds: 2000)]
    internal static partial Regex MesRegex();

    [GeneratedRegex(@"[^\d]", RegexOptions.None, matchTimeoutMilliseconds: 2000)]
    internal static partial Regex CnpjRegex();

    [GeneratedRegex(@"(\d+(?:,\d+)?)\s*%", RegexOptions.None, matchTimeoutMilliseconds: 2000)]
    internal static partial Regex PercentualRegex();

    [GeneratedRegex(@"\d+", RegexOptions.None, matchTimeoutMilliseconds: 2000)]
    internal static partial Regex ValoresInteiroRegex();

    [GeneratedRegex(@"\s+", RegexOptions.ExplicitCapture, matchTimeoutMilliseconds: 2000)]
    internal static partial Regex TextoLimpoRegex();

    [GeneratedRegex(@"^(.+?)\s*-\s*Rating", RegexOptions.None, matchTimeoutMilliseconds: 2000)]
    internal static partial Regex BancoRegex();
}

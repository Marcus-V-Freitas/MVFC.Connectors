namespace MVFC.Connectors.BancoData.Extensoes;

internal static partial class RegexExtensoes
{
    [GeneratedRegex(@"(\d{4})")]
    internal static partial Regex AnoRegex();

    [GeneratedRegex(@"(\d)T(\d{4})")]
    internal static partial Regex TrimestreRegex();

    [GeneratedRegex(@"(-?\d+(?:,\d+)?)")]
    internal static partial Regex ValorMonetarioRegex();

    [GeneratedRegex(@"(\w+)\s+de\s+(\d{4})")]
    internal static partial Regex MesRegex();

    [GeneratedRegex(@"[^\d]")]
    internal static partial Regex CnpjRegex();

    [GeneratedRegex(@"(\d+(?:,\d+)?)\s*%")]
    internal static partial Regex PercentualRegex();

    [GeneratedRegex(@"\d+")]
    internal static partial Regex ValoresInteiroRegex();

    [GeneratedRegex(@"\s+")]
    internal static partial Regex TextoLimpoRegex();

    [GeneratedRegex(@"^(.+?)\s*-\s*Rating")]
    internal static partial Regex BancoRegex();
}
namespace MVFC.Connectors.Financas.Investo.Modelos.Dtos;

public sealed record InvestoCarteitaDto(
        [property: JsonPropertyName("sigla")] string Sigla,
        [property: JsonPropertyName("nomeFundo")] string NomeFundo,
        [property: JsonPropertyName("nomeIndexador")] string NomeIndexador,
        [property: JsonPropertyName("nomeAtivo")] string NomeAtivo,
        [property: JsonPropertyName("nomeAtivoCompleto")] string NomeAtivoCompleto,
        [property: JsonPropertyName("qtdAtivos")] string QtdAtivos,
        [property: JsonPropertyName("precoAtivo")] string PrecoAtivo,
        [property: JsonPropertyName("valorAtivos")] string ValorAtivos,
        [property: JsonPropertyName("pesoCaixa")] string PesoCaixa,
        [property: JsonPropertyName("pesoAtivo")] string PesoAtivo,
        [property: JsonPropertyName("data")] string Data,
        [property: JsonPropertyName("cotaPatrimonial")] string CotaPatrimonial,
        [property: JsonPropertyName("patrimonioLiquido")] string PatrimonioLiquido,
        [property: JsonPropertyName("valorCaixa")] string ValorCaixa);
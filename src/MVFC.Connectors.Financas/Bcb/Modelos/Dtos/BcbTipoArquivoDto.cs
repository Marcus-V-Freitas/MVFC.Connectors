namespace MVFC.Connectors.Financas.Bcb.Modelos.Dtos;

public sealed record BcbTipoArquivoDto(
        [property: JsonPropertyName("codigo")] int Codigo,
        [property: JsonPropertyName("nome")] string Nome,
        [property: JsonPropertyName("periodo")] int Periodo,
        [property: JsonPropertyName("excecoesDataBase")] object ExcecoesDataBase,
        [property: JsonPropertyName("formatoPadrao")] string FormatoPadrao);
namespace MVFC.Connectors.Financas.Bcb.Modelos.Dtos;

public sealed record BcbDocumentoDto(
        [property: JsonPropertyName("cnpj")] string Cnpj,
        [property: JsonPropertyName("tipo")] BcbTipoArquivoDto Tipo,
        [property: JsonPropertyName("anoMes")] string AnoMes,
        [property: JsonPropertyName("nomeArquivo")] string NomeArquivo,
        [property: JsonPropertyName("tamanhoArquivo")] string TamanhoArquivo);
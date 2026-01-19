namespace MVFC.Connectors.Financas.Bcb.Modelos.Request;

public sealed record BcbInstituicaoRequest(
        [property: JsonPropertyName("segmento")] BcbSegmentoDto? Segmento = null,
        [property: JsonPropertyName("nome")] string? Nome = null,
        [property: JsonPropertyName("cnpj")] string? Cnpj = null,
        [property: JsonPropertyName("pais")] string? Pais = null,
        [property: JsonPropertyName("estado")] BcbEstadoDto? Estado = null,
        [property: JsonPropertyName("municipio")] BcbMunicipioDto? Municipio = null,
        [property: JsonPropertyName("incluirInstituicoesLiquidacao")] bool IncluirInstituicoesLiquidacao = false,
        [property: JsonPropertyName("incluirAgencias")] bool IncluirAgencias = true,
        int TamanhoPagina = 20,
        int NumeroPagina = 0) : 
            BbcRequest(TamanhoPagina, NumeroPagina);
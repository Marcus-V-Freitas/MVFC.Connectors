namespace MVFC.Connectors.Financas.Bcb.Modelos.Request;

public sealed record BcbAgenciaRequest(
        [property: JsonPropertyName("idBacenInstituicao")] string IdBacenInstituicao,
        [property: JsonPropertyName("pais")] string Pais,
        [property: JsonPropertyName("siglaEstado")] string SiglaEstado,
        [property: JsonPropertyName("municipio")] string Municipio,
        int TamanhoPagina = 20,
        int NumeroPagina = 0) :
            BbcRequest(TamanhoPagina, NumeroPagina);
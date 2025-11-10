namespace MVFC.Connectors.Justica.DataJud.Modelos;

public sealed record DataJudOrgaoJulgadorDto(
    [property: JsonPropertyName("codigoMunicipioIBGE")] int CodigoMunicipioIBGE,
    [property: JsonPropertyName("codigo")] int Codigo,
    [property: JsonPropertyName("nome")] string Nome);
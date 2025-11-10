namespace MVFC.Connectors.Justica.DataJud.Modelos.Request;

public sealed record DataJudProcessoRequest(
    [property: JsonPropertyName("query")] DataJudProcessoQuery Query)
{
    public static DataJudProcessoRequest CriarPorNumero(string numeroProcesso) =>
        new(new DataJudProcessoQuery(new DataJudProcessoMatch(numeroProcesso)));
}
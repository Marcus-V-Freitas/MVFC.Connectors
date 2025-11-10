namespace MVFC.Connectors.Conversores.GoogleTradutor;

public interface IGoogleTradutorApi : IConnectorApi
{
    [Get("/translate_a/single?client=gtx&dt=t")]
    Task<ApiResponse<string>> TraduzirTextoAsync(
        [AliasAs("q")] string texto,
        [AliasAs("sl")] string idiomaOrigem,
        [AliasAs("tl")] string idiomaDestino);
}
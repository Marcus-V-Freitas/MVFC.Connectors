namespace MVFC.Connectors.Sicoob.Modelos.Response;

public sealed record SicoobResponse<T>(
    [property: JsonPropertyName("resultado")] T Resultado);
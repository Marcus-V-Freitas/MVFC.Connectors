namespace MVFC.Connectors.Sicoob.Modelos.Response;

public sealed record HealthResponse(
    [property: JsonPropertyName("status")] string Status);
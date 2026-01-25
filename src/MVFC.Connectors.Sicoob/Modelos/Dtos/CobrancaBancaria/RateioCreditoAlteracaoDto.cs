namespace MVFC.Connectors.Sicoob.Modelos.Dtos.CobrancaBancaria;

public sealed record RateioCreditoAlteracaoDto(
    [property: JsonPropertyName("tipoOperacao")] int TipoOperacao,
    [property: JsonPropertyName("rateioCreditos")] RateioCreditoDto[] RateioCreditos);
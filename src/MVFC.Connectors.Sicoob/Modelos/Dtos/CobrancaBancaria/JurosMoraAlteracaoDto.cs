namespace MVFC.Connectors.Sicoob.Modelos.Dtos.CobrancaBancaria;

public sealed record JurosMoraAlteracaoDto(
    [property: JsonPropertyName("tipoJurosMora")] TipoJurosMora TipoJurosMora,
    [property: JsonPropertyName("dataJurosMora")] DateOnly? DataJurosMora = null,
    [property: JsonPropertyName("valorJurosMora")] decimal? ValorJurosMora = null);

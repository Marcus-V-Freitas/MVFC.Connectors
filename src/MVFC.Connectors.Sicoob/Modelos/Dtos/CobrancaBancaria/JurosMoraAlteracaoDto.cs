namespace MVFC.Connectors.Sicoob.Modelos.Dtos.CobrancaBancaria;

public sealed record JurosMoraAlteracao(
    [property: JsonPropertyName("tipoJurosMora")] TipoJurosMora TipoJurosMora,
    [property: JsonPropertyName("dataJurosMora")] DateOnly? DataJurosMora = null,
    [property: JsonPropertyName("valorJurosMora")] decimal? ValorJurosMora = null);
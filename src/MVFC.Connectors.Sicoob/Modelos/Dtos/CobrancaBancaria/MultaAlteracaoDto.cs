namespace MVFC.Connectors.Sicoob.Modelos.Dtos.CobrancaBancaria;

public sealed record MultaAlteracaoDto(
    [property: JsonPropertyName("tipoMulta")] TipoMulta TipoMulta,
    [property: JsonPropertyName("dataMulta")] DateOnly? DataMulta = null,
    [property: JsonPropertyName("valorMulta")] decimal? ValorMulta = null);
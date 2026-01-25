namespace MVFC.Connectors.Sicoob.Modelos.Dtos.CobrancaBancaria;

public sealed record DescontoAlteracaoDto(
    [property: JsonPropertyName("tipoDesconto")] TipoDesconto TipoDesconto,
    [property: JsonPropertyName("dataPrimeiroDesconto")] DateOnly? DataPrimeiroDesconto = null,
    [property: JsonPropertyName("valorPrimeiroDesconto")] decimal? ValorPrimeiroDesconto = null,
    [property: JsonPropertyName("dataSegundoDesconto")] DateOnly? DataSegundoDesconto = null,
    [property: JsonPropertyName("valorSegundoDesconto")] decimal? ValorSegundoDesconto = null,
    [property: JsonPropertyName("dataTerceiroDesconto")] DateOnly? DataTerceiroDesconto = null,
    [property: JsonPropertyName("valorTerceiroDesconto")] decimal? ValorTerceiroDesconto = null);
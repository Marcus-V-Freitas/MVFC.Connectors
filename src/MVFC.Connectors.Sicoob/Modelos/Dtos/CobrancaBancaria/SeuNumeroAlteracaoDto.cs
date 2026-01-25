namespace MVFC.Connectors.Sicoob.Modelos.Dtos.CobrancaBancaria;

public sealed record SeuNumeroAlteracaoDto(
    [property: JsonPropertyName("seuNumero")] string SeuNumero);
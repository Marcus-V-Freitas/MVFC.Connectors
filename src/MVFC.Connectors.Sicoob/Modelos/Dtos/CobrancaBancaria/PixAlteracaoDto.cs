namespace MVFC.Connectors.Sicoob.Modelos.Dtos.CobrancaBancaria;

public sealed record PixAlteracaoDto(
    [property: JsonPropertyName("utilizarPix")] bool UtilizarPix);
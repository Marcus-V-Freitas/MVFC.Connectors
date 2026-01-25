namespace MVFC.Connectors.Sicoob.Modelos.Response.CobrancaBancaria;

public sealed record FaixaNossoNumeroResponse(
    [property: JsonPropertyName("numeroInicial")] long NumeroInicial,
    [property: JsonPropertyName("numeroFinal")] long NumeroFinal,
    [property: JsonPropertyName("validaDigitoVerificadorNossoNumero")] bool ValidaDigitoVerificadorNossoNumero);
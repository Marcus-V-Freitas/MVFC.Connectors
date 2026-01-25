namespace MVFC.Connectors.Sicoob.Modelos.Dtos.CobrancaBancaria;

public sealed record RateioCreditoDto( 
    [property: JsonPropertyName("numeroBanco")] int NumeroBanco,
    [property: JsonPropertyName("numeroAgencia")] int NumeroAgencia,
    [property: JsonPropertyName("numeroContaCorrente")] string NumeroContaCorrente,
    [property: JsonPropertyName("contaPrincipal")] bool ContaPrincipal,
    [property: JsonPropertyName("codigoTipoValorRateio")] CodigoTipoValorRateio CodigoTipoValorRateio,
    [property: JsonPropertyName("valorRateio")] string ValorRateio,
    [property: JsonPropertyName("codigoTipoCalculoRateio")] CodigoTipoCalculoRateio CodigoTipoCalculoRateio,
    [property: JsonPropertyName("numeroCpfCnpjTitular")] string NumeroCpfCnpjTitular,
    [property: JsonPropertyName("nomeTitular")] string NomeTitular,
    [property: JsonPropertyName("codigoFinalidadeTed")] CodigoFinalidadeTed CodigoFinalidadeTed,
    [property: JsonPropertyName("codigoTipoContaDestinoTed")] CodigoTipoContaDestinoTed CodigoTipoContaDestinoTed,
    [property: JsonPropertyName("quantidadeDiasFloat")] int QuantidadeDiasFloat,
    [property: JsonPropertyName("dataFloatCredito")] string DataFloatCredito);
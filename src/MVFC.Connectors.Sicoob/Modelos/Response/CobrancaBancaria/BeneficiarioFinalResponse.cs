namespace MVFC.Connectors.Sicoob.Modelos.Response.CobrancaBancaria;

public sealed record BeneficiarioFinalResponse(
    [property: JsonPropertyName("numeroCpfCnpj")] string NumeroCpfCnpj,
    [property: JsonPropertyName("nome")] string Nome);
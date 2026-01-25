namespace MVFC.Connectors.Sicoob.Modelos.Request.CobrancaBancaria;

public sealed record BeneficiarioFinalRequest(
    [property: JsonPropertyName("numeroCpfCnpj")] string NumeroCpfCnpj,
    [property: JsonPropertyName("nome")] string Nome);
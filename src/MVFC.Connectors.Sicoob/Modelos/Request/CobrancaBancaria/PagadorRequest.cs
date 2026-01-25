namespace MVFC.Connectors.Sicoob.Modelos.Request.CobrancaBancaria;

public sealed record PagadorRequest(
    [property: JsonPropertyName("numeroCliente")] int NumeroCliente,
    [property: JsonPropertyName("numeroCpfCnpj")] string NumeroCpfCnpj,
    [property: JsonPropertyName("nome")] string Nome,
    [property: JsonPropertyName("endereco")] string Endereco,
    [property: JsonPropertyName("bairro")] string Bairro,
    [property: JsonPropertyName("cidade")] string Cidade,
    [property: JsonPropertyName("cep")] string Cep,
    [property: JsonPropertyName("uf")] string Uf)
{
    [JsonPropertyName("email")]
    public string? Email { get; init; }
}
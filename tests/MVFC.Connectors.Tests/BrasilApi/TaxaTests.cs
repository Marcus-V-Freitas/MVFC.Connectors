namespace MVFC.Connectors.Tests.BrasilApi;

public sealed class TaxaTests
{
    public static TheoryData<ITaxaBrasilApi> Apis =>
      [
          TaxaBrasilApiExtensoes.ObterTaxaBrasilApi(),
          TestsHelpers.ObterApi<ITaxaBrasilApi>(s => s.AddTaxaBrasilApi()),
       ];

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task RecuperarTodasAsTaxas_DeveRetornarItens(ITaxaBrasilApi api)
    {
        // Arrange & Act
        var taxas = await api.GetTaxasAsync();

        // Assert
        taxas.IsSuccessful.Should().BeTrue();
        taxas.Content.Should().NotBeNull();
    }

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task RecuperarBancoPorCodigo_DeveRetornarItem(ITaxaBrasilApi api)
    {
        // Arrange
        const string sigla = "IPCA";

        // Act
        var taxa = await api.GetTaxaAsync(sigla);

        // Assert
        taxa.IsSuccessful.Should().BeTrue();
        taxa.Content?.Should().NotBeNull();
    }
}
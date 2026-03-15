namespace MVFC.Connectors.Tests.BrasilApi;

public sealed class TaxaTests : ConnectorTestsBase<ITaxaBrasilApi>
{
    protected override ITaxaBrasilApi ManualApi => TaxaBrasilApiExtensoes.ObterTaxaBrasilApi();

    protected override ITaxaBrasilApi ServiceCollectionApi => TestsHelpers.ObterApi<ITaxaBrasilApi>(s => s.AddTaxaBrasilApi());

    public static TheoryData<RegistrationMode> Modes => [RegistrationMode.Manual, RegistrationMode.ServiceCollection];

    [Theory]
    [MemberData(nameof(Modes))]
    public Task GarantirQueApiEstaConfiguradaEBuscandoDados(RegistrationMode mode) =>
        ValidarConfiguracaoApi(mode);

    protected override Task ExecutarChamadaBasica(ITaxaBrasilApi api) =>
        api.ObterTaxasAsync();

    [Fact]
    public async Task RecuperarTodasAsTaxas_DeveRetornarItens()
    {
        // Arrange & Act
        var taxas = await ManualApi.ObterTaxasAsync();

        // Assert
        taxas.IsSuccessful.Should().BeTrue();
        taxas.Content.Should().NotBeNull();
    }

    [Fact]
    public async Task RecuperarTaxaPorSigla_DeveRetornarItem()
    {
        // Arrange
        const string SIGLA = "IPCA";

        // Act
        var taxa = await ManualApi.ObterTaxaPorSiglaAsync(SIGLA);

        // Assert
        taxa.IsSuccessful.Should().BeTrue();
        taxa.Content?.Should().NotBeNull();
    }
}

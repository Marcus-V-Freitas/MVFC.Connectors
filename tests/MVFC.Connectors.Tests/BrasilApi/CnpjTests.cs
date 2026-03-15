namespace MVFC.Connectors.Tests.BrasilApi;

public sealed class CnpjTests : ConnectorTestsBase<ICnpjBrasilApi>
{
    protected override ICnpjBrasilApi ManualApi => CnpjBrasilApiExtensoes.ObterCnpjBrasilApi();

    protected override ICnpjBrasilApi ServiceCollectionApi => TestsHelpers.ObterApi<ICnpjBrasilApi>(s => s.AddCnpjBrasilApi());

    public static TheoryData<RegistrationMode> Modes => [RegistrationMode.Manual, RegistrationMode.ServiceCollection];

    [Theory]
    [MemberData(nameof(Modes))]
    public Task GarantirQueApiEstaConfiguradaEBuscandoDados(RegistrationMode mode) =>
        ValidarConfiguracaoApi(mode);

    protected override Task ExecutarChamadaBasica(ICnpjBrasilApi api) =>
        api.ObterEmpresaPorCnpjAsync("07174743000399");

    [Fact]
    public async Task RecuperarCNPJ_DeveRetornarDadosCorretos()
    {
        // Arrange &
        const string CNPJ = "07174743000399";

        // Act
        var resultado = await ManualApi.ObterEmpresaPorCnpjAsync(CNPJ);

        // Assert
        resultado.IsSuccessful.Should().BeTrue();
        resultado.Content.Should().NotBeNull();
        resultado.Content?.RazaoSocial.Should().Be("GFT BRASIL CONSULTORIA INFORMATICA LTDA.");
    }
}

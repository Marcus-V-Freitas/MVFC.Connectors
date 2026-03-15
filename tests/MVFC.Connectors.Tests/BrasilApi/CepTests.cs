namespace MVFC.Connectors.Tests.BrasilApi;

public sealed class CepTests : ConnectorTestsBase<ICepBrasilApi>
{
    protected override ICepBrasilApi ManualApi => CepBrasilApiExtensoes.ObterCepBrasilApi();

    protected override ICepBrasilApi ServiceCollectionApi => TestsHelpers.ObterApi<ICepBrasilApi>(s => s.AddCepBrasilApi());

    public static TheoryData<RegistrationMode> Modes => [RegistrationMode.Manual, RegistrationMode.ServiceCollection];

    [Theory]
    [MemberData(nameof(Modes))]
    public Task GarantirQueApiEstaConfiguradaEBuscandoDados(RegistrationMode mode) =>
        ValidarConfiguracaoApi(mode);

    protected override Task ExecutarChamadaBasica(ICepBrasilApi api) =>
        api.ObterCepPorNumeroAsync("01001000", "v1");

    [Fact]
    public async Task RecuperarCep_v1_DeveRetornarDadosCorretos()
    {
        // Arrange
        const string CEP = "01001000";
        const string VERSION = "v1";

        // Act
        var resultado = await ManualApi.ObterCepPorNumeroAsync(CEP, VERSION);

        // Assert
        resultado.IsSuccessful.Should().BeTrue();
        resultado.Content.Should().NotBeNull();
        resultado.Content?.Cep.Should().Be(CEP);
        resultado.Content?.State.Should().Be("SP");
        resultado.Content?.City.Should().Be("São Paulo");
        resultado.Content?.Neighborhood.Should().Be("Sé");
        resultado.Content?.Street.Should().Contain("Praça da Sé");
    }

    [Fact]
    public async Task RecuperarCep_v2_DeveRetornarDadosCorretos()
    {
        // Arrange
        const string CEP = "01001000";
        const string VERSION = "v2";

        // Act
        var resultado = await ManualApi.ObterCepPorNumeroAsync(CEP, VERSION);

        // Assert
        resultado.IsSuccessful.Should().BeTrue();
        resultado.Content.Should().NotBeNull();
        resultado.Content?.Cep.Should().Be(CEP);
        resultado.Content?.State.Should().Be("SP");
        resultado.Content?.City.Should().Be("São Paulo");
        resultado.Content?.Neighborhood.Should().Be("Sé");
        resultado.Content?.Street.Should().Contain("Praça da Sé");
    }
}

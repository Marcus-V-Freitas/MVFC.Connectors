namespace MVFC.Connectors.Tests.BrasilApi;

public sealed class CorretorasTests : ConnectorTestsBase<ICorretoraBrasilApi>
{
    protected override ICorretoraBrasilApi ManualApi => CorretorasBrasilApiExtensoes.ObterCorretoraBrasilApi();

    protected override ICorretoraBrasilApi ServiceCollectionApi => TestsHelpers.ObterApi<ICorretoraBrasilApi>(s => s.AddCorretoraBrasilApi());

    public static TheoryData<RegistrationMode> Modes => [RegistrationMode.Manual, RegistrationMode.ServiceCollection];

    [Theory]
    [MemberData(nameof(Modes))]
    public Task GarantirQueApiEstaConfiguradaEBuscandoDados(RegistrationMode mode) =>
        ValidarConfiguracaoApi(mode);

    protected override Task ExecutarChamadaBasica(ICorretoraBrasilApi api) =>
        api.ObterCorretorasAsync();

    [Fact]
    public async Task RecuperarTodasAsCorretoras_DeveRetornarItens()
    {
        // Arrange & Act
        var corretoras = await ManualApi.ObterCorretorasAsync();

        // Assert
        corretoras.IsSuccessful.Should().BeTrue();
        corretoras.Content.Should().NotBeNull();
    }

    [Fact]
    public async Task RecuperarCorretoraPorCnpj_DeveRetornarItem()
    {
        // Arrange
        const string CNPJ = "02332886000104";

        // Act
        var corretora = await ManualApi.ObterCorretoraPorCnpjAsync(CNPJ);

        // Assert
        corretora.IsSuccessful.Should().BeTrue();
        corretora.Content?.NomeComercial.Should().Be("XP INVESTIMENTOS");
    }
}

namespace MVFC.Connectors.Tests.BrasilApi;

public sealed class CptecBrasilApiTests : ConnectorTestsBase<ICptecBrasilApi>
{
    protected override ICptecBrasilApi ManualApi => CptecBrasilApiExtensoes.ObterCptecBrasilApi();

    protected override ICptecBrasilApi ServiceCollectionApi => TestsHelpers.ObterApi<ICptecBrasilApi>(s => s.AddCptecBrasilApi());

    public static TheoryData<RegistrationMode> Modes => [RegistrationMode.Manual, RegistrationMode.ServiceCollection];

    [Theory]
    [MemberData(nameof(Modes))]
    public Task GarantirQueApiEstaConfiguradaEBuscandoDados(RegistrationMode mode) =>
        ValidarConfiguracaoApi(mode);

    protected override Task ExecutarChamadaBasica(ICptecBrasilApi api) =>
        api.ObterCidadesAsync();

    [Fact]
    public async Task ObterCidadesAsync_DeveRetornarItens()
    {
        // Arrange & Act
        var cidades = await ManualApi.ObterCidadesAsync();

        // Assert
        cidades.IsSuccessful.Should().BeTrue();
        cidades.Content.Should().NotBeNull();
        cidades.Content.Should().NotBeEmpty();
    }

    [Fact]
    public async Task ObterCidadesPorNomeAsync_DeveRetornarItens()
    {
        // Arrange
        const string NOME_DA_CIDADE = "São Paulo";

        // Act
        var cidades = await ManualApi.ObterCidadesPorNomeAsync(NOME_DA_CIDADE);

        // Assert
        cidades.IsSuccessful.Should().BeTrue();
        cidades.Content.Should().NotBeNull();
        cidades.Content.Should().NotBeEmpty();
    }

    [Fact]
    public async Task ObterPrevisaoPorCodigoDaCidadeAsync_Console_DeveRetornarItem()
    {
        // Arrange
        const int CODIGO_DA_CIDADE = 244; // São Paulo

        // Act
        var previsao = await ManualApi.ObterPrevisaoPorCodigoDaCidadeAsync(CODIGO_DA_CIDADE);

        // Assert
        previsao.IsSuccessful.Should().BeTrue();
        previsao.Content.Should().NotBeNull();
    }

    [Fact]
    public async Task ObterPrevisaoPorCodigoDaCidadeEDiasAsync_DeveRetornarItem()
    {
        // Arrange
        const int CODIGO_DA_CIDADE = 244;
        const int DIAS = 3;

        // Act
        var previsao = await ManualApi.ObterPrevisaoPorCodigoDaCidadeEDiasAsync(CODIGO_DA_CIDADE, DIAS);

        // Assert
        previsao.IsSuccessful.Should().BeTrue();
        previsao.Content.Should().NotBeNull();
    }

    [Fact]
    public async Task ObterOndasPorCodigoDaCidadeAsync_DeveRetornarItem()
    {
        // Arrange
        const int CODIGO_DA_CIDADE = 241;

        // Act
        var ondas = await ManualApi.ObterOndasPorCodigoDaCidadeAsync(CODIGO_DA_CIDADE);

        // Assert
        ondas.IsSuccessful.Should().BeTrue();
        ondas.Content.Should().NotBeNull();
    }
}

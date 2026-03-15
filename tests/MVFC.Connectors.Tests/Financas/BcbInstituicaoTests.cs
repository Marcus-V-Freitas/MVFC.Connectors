namespace MVFC.Connectors.Tests.Financas;

public sealed class BcbInstituicaoTests : ConnectorTestsBase<IBcbInstituicaoApi>
{
    protected override IBcbInstituicaoApi ManualApi => BcbInstituicaoExtensoes.ObterBcbInstituicaoApi();

    protected override IBcbInstituicaoApi ServiceCollectionApi => TestsHelpers.ObterApi<IBcbInstituicaoApi>(s => s.AddBcbInstituicao());

    public static TheoryData<RegistrationMode> Modes => [RegistrationMode.Manual, RegistrationMode.ServiceCollection];

    [Theory]
    [MemberData(nameof(Modes))]
    public Task GarantirQueApiEstaConfiguradaEBuscandoDados(RegistrationMode mode) =>
        ValidarConfiguracaoApi(mode);

    protected override Task ExecutarChamadaBasica(IBcbInstituicaoApi api) =>
        api.ObterSegmentosAsync();

    [Fact]
    public async Task ObterInstituicoesReguladasAsync_DeveRetornarItemAsync()
    {
        // Arrange
        BcbInstituicaoRequest request = new();

        // Act
        var bcbResponse = await ManualApi.ObterInstituicoesReguladasAsync(request);

        // Assert
        bcbResponse.IsSuccessful.Should().BeTrue();
        bcbResponse.Content.Should().NotBeNull();
        bcbResponse.Content!.Content.Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ObterInstituicaoPorCnpj_DeveRetornarItemAsync()
    {
        // Arrange
        const string CNPJ = "54647259";

        // Act
        var bcbResponse = await ManualApi.ObterInstituicaoPorCnpj(CNPJ);

        // Assert
        bcbResponse.IsSuccessful.Should().BeTrue();
        bcbResponse.Content.Should().NotBeNull();
        bcbResponse.Content!.Should().NotBeNull();
    }

    [Fact]
    public async Task ObterInstituicoesParticipantesDoPixAsync_DeveRetornarItemAsync()
    {
        // Arrange
        BcbParticipanteDoPixRequest request = new();

        // Act
        var bcbResponse = await ManualApi.ObterInstituicoesParticipantesDoPixAsync(request);

        // Assert
        bcbResponse.IsSuccessful.Should().BeTrue();
        bcbResponse.Content.Should().NotBeNull();
        bcbResponse.Content!.Should().NotBeNull();
    }

    [Fact]
    public async Task ObterSegmentosAsync_DeveRetornarItemAsync()
    {
        // Arrange & Act
        var bcbResponse = await ManualApi.ObterSegmentosAsync();

        // Assert
        bcbResponse.IsSuccessful.Should().BeTrue();
        bcbResponse.Content.Should().NotBeNull();
        bcbResponse.Content!.Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ObterEstadosAsync_DeveRetornarItemAsync()
    {
        // Arrange & Act
        var bcbResponse = await ManualApi.ObterEstadosAsync();

        // Assert
        bcbResponse.IsSuccessful.Should().BeTrue();
        bcbResponse.Content.Should().NotBeNull();
        bcbResponse.Content!.Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task ObterPaisesAsync_DeveRetornarItemAsync()
    {
        // Arrange & Act
        var bcbResponse = await ManualApi.ObterPaisesAsync();

        // Assert
        bcbResponse.IsSuccessful.Should().BeTrue();
        bcbResponse.Content.Should().NotBeNull();
        bcbResponse.Content!.Should().NotBeNullOrEmpty();
    }
}

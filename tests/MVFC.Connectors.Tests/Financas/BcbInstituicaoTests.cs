namespace MVFC.Connectors.Tests.Financas;

public sealed class BcbInstituicaoTests
{
    public static TheoryData<IBcbInstituicaoApi> Apis =>
     [
          BcbInstituicaoExtensoes.ObterBcbInstituicaoApi(),
          TestsHelpers.ObterApi<IBcbInstituicaoApi>(s => s.AddBcbInstituicao()),
     ];

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task ObterInstituicoesReguladasAsync_DeveRetornarItemAsync(IBcbInstituicaoApi api)
    {
        // Arrange
        BcbInstituicaoRequest request = new();

        // Act
        var bcbResponse = await api.ObterInstituicoesReguladasAsync(request);

        // Assert
        bcbResponse.IsSuccessful.Should().BeTrue();
        bcbResponse.Content.Should().NotBeNull();
        bcbResponse.Content!.Content.Should().NotBeNullOrEmpty();
    }

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task ObterInstituicaoPorCnpj_DeveRetornarItemAsync(IBcbInstituicaoApi api)
    {
        // Arrange
        const string cnpj = "54647259";

        // Act
        var bcbResponse = await api.ObterInstituicaoPorCnpj(cnpj);

        // Assert
        bcbResponse.IsSuccessful.Should().BeTrue();
        bcbResponse.Content.Should().NotBeNull();
        bcbResponse.Content!.Should().NotBeNull();
    }

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task ObterInstituicoesParticipantesDoPixAsync_DeveRetornarItemAsync(IBcbInstituicaoApi api)
    {
        // Arrange
        BcbParticipanteDoPixRequest request = new();

        // Act
        var bcbResponse = await api.ObterInstituicoesParticipantesDoPixAsync(request);

        // Assert
        bcbResponse.IsSuccessful.Should().BeTrue();
        bcbResponse.Content.Should().NotBeNull();
        bcbResponse.Content!.Should().NotBeNull();
    }

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task ObterSegmentosAsync_DeveRetornarItemAsync(IBcbInstituicaoApi api)
    {
        // Arrange & Act
        var bcbResponse = await api.ObterSegmentosAsync();

        // Assert
        bcbResponse.IsSuccessful.Should().BeTrue();
        bcbResponse.Content.Should().NotBeNull();
        bcbResponse.Content!.Should().NotBeNullOrEmpty();
    }

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task ObterEstadosAsync_DeveRetornarItemAsync(IBcbInstituicaoApi api)
    {
        // Arrange & Act
        var bcbResponse = await api.ObterEstadosAsync();

        // Assert
        bcbResponse.IsSuccessful.Should().BeTrue();
        bcbResponse.Content.Should().NotBeNull();
        bcbResponse.Content!.Should().NotBeNullOrEmpty();
    }

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task ObterPaisesAsync_DeveRetornarItemAsync(IBcbInstituicaoApi api)
    {
        // Arrange & Act
        var bcbResponse = await api.ObterPaisesAsync();

        // Assert
        bcbResponse.IsSuccessful.Should().BeTrue();
        bcbResponse.Content.Should().NotBeNull();
        bcbResponse.Content!.Should().NotBeNullOrEmpty();
    }
}
namespace MVFC.Connectors.Tests.BrasilApi;

public sealed class CptecBrasilApiTests
{
    public static TheoryData<ICptecBrasilApi> Apis =>
        [
            CptecBrasilApiExtensoes.ObterCptecBrasilApi(),
            TestsHelpers.ObterApi<ICptecBrasilApi>(s => s.AddCptecBrasilApi()),
        ];

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task ObterCidadesAsync_DeveRetornarItens(ICptecBrasilApi api)
    {
        // Arrange & Act
        var cidades = await api.ObterCidadesAsync();

        // Assert
        cidades.IsSuccessful.Should().BeTrue();
        cidades.Content.Should().NotBeNull();
        cidades.Content.Should().NotBeEmpty();
    }

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task ObterCidadesPorNomeAsync_DeveRetornarItens(ICptecBrasilApi api)
    {
        // Arrange
        const string nomeDaCidade = "São Paulo";

        // Act
        var cidades = await api.ObterCidadesPorNomeAsync(nomeDaCidade);

        // Assert
        cidades.IsSuccessful.Should().BeTrue();
        cidades.Content.Should().NotBeNull();
        cidades.Content.Should().NotBeEmpty();
    }

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task ObterPrevisaoPorCodigoDaCidadeAsync_Console_DeveRetornarItem(ICptecBrasilApi api)
    {
        // Arrange
        const int codigoDaCidade = 244; // São Paulo

        // Act
        var previsao = await api.ObterPrevisaoPorCodigoDaCidadeAsync(codigoDaCidade);

        // Assert
        previsao.IsSuccessful.Should().BeTrue();
        previsao.Content.Should().NotBeNull();
    }

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task ObterPrevisaoPorCodigoDaCidadeEDiasAsync_DeveRetornarItem(ICptecBrasilApi api)
    {
        // Arrange
        const int codigoDaCidade = 244;
        const int dias = 3;

        // Act
        var previsao = await api.ObterPrevisaoPorCodigoDaCidadeEDiasAsync(codigoDaCidade, dias);

        // Assert
        previsao.IsSuccessful.Should().BeTrue();
        previsao.Content.Should().NotBeNull();
    }

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task ObterOndasPorCodigoDaCidadeAsync_DeveRetornarItem(ICptecBrasilApi api)
    {
        // Arrange
        const int codigoDaCidade = 241;

        // Act
        var ondas = await api.ObterOndasPorCodigoDaCidadeAsync(codigoDaCidade);

        // Assert
        ondas.IsSuccessful.Should().BeTrue();
        ondas.Content.Should().NotBeNull();
    }
}
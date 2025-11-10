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
    public async Task GetCidadesAsync_DeveRetornarItens(ICptecBrasilApi api)
    {
        // Arrange & Act
        var cidades = await api.GetCidadesAsync();

        // Assert
        cidades.IsSuccessful.Should().BeTrue();
        cidades.Content.Should().NotBeNull();
        cidades.Content.Should().NotBeEmpty();
    }

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task GetCidadesByNameAsync_DeveRetornarItens(ICptecBrasilApi api)
    {
        // Arrange
        const string cityName = "São Paulo";

        // Act
        var cidades = await api.GetCidadesByNameAsync(cityName);

        // Assert
        cidades.IsSuccessful.Should().BeTrue();
        cidades.Content.Should().NotBeNull();
        cidades.Content.Should().NotBeEmpty();
    }

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task GetPrevisaoByCityCodeAsync_Console_DeveRetornarItem(ICptecBrasilApi api)
    {
        // Arrange &
        const int cityCode = 244; // São Paulo

        // Act
        var previsao = await api.GetPrevisaoByCityCodeAsync(cityCode);

        // Assert
        previsao.IsSuccessful.Should().BeTrue();
        previsao.Content.Should().NotBeNull();
    }

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task GetPrevisaoByCityCodeAndDaysAsync_Console_DeveRetornarItem(ICptecBrasilApi api)
    {
        // Arrange
        const int cityCode = 244;
        const int days = 3;

        // Act
        var previsao = await api.GetPrevisaoByCityCodeAndDaysAsync(cityCode, days);

        // Assert
        previsao.IsSuccessful.Should().BeTrue();
        previsao.Content.Should().NotBeNull();
    }

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task GetOndasByCityCodeAsync_Console_DeveRetornarItem(ICptecBrasilApi api)
    {
        // Arrange
        const int cityCode = 241;

        // Act
        var ondas = await api.GetOndasByCityCodeAsync(cityCode);

        // Assert
        ondas.IsSuccessful.Should().BeTrue();
        ondas.Content.Should().NotBeNull();
    }
}
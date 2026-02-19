namespace MVFC.Connectors.Tests.BrasilApi;

public sealed class NcmTests
{
    public static TheoryData<INcmBrasilApi> Apis =>
        new()
        {
            { NcmBrasilApiExtensoes.ObterNcmBrasilApi() },
            { TestsHelpers.ObterApi<INcmBrasilApi>(s => s.AddNcmBrasilApi()) },
        };

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task ObterNcmsAsync_DeveRetornarListaDeNcm(INcmBrasilApi api)
    {
        // Arrange & Act
        var ncms = await api.ObterNcmsAsync();

        // Assert
        ncms.IsSuccessStatusCode.Should().BeTrue();
        ncms.Content.Should().NotBeNull();
    }

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task ObterNcmsPorCodigoAsync_DeveRetornarListaDeNcm(INcmBrasilApi api)
    {
        // Arrange
        const string codigo = "0101";

        // Act
        var ncms = await api.ObterNcmsPorCodigoAsync(codigo);

        // Assert
        ncms.IsSuccessStatusCode.Should().BeTrue();
        ncms.Content.Should().NotBeNull();
    }

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task ObterNcmPorCodigoAsync_DeveRetornarNcm(INcmBrasilApi api)
    {
        // Arrange
        const string codigo = "0101.2";

        // Act
        var ncm = await api.ObterNcmPorCodigoAsync(codigo);

        // Assert
        ncm.IsSuccessStatusCode.Should().BeTrue();
        ncm.Content.Should().NotBeNull();
        ncm.Content?.NumeroAto.Should().Be("272");
    }
}
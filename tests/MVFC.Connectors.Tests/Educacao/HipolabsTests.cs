namespace MVFC.Connectors.Tests.Educacao;

public sealed class HipolabsTests
{
    public static TheoryData<IHipolabsApi> Apis =>
        new()
        {
            { HipolabsExtensoes.ObterHipolabsApi() },
            { TestsHelpers.ObterApi<IHipolabsApi>(s => s.AddHipolabs()) },
        };

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task ObterUniversidadesPorPais_DeveRetornarItemAsync(IHipolabsApi api)
    {
        // Arrange
        const string pais = "Brazil";

        // Act
        var phishing = await api.ObterUniversidadesPorPaisAsync(pais);

        // Assert
        phishing.IsSuccessful.Should().BeTrue();
        phishing.Content.Should().NotBeNullOrEmpty();
    }
}
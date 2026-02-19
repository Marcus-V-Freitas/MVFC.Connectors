namespace MVFC.Connectors.Tests.Geo;

public sealed class GeoNetTests
{
    public static TheoryData<IGeoNetApi> Apis =>
    new()
    {
        { GeoNetApiExtensoes.ObterGeoNetApi() },
        { TestsHelpers.ObterApi<IGeoNetApi>(s => s.AddGeoNet()) },
    };

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task ObterDnsGeosPorDominioAsync_DeveRetornarItemAsync(IGeoNetApi api)
    {
        // Arrange
        const string dominio = "google.com";

        // Act
        var dnsGeos = await api.ObterDnsGeosPorDominioAsync(dominio);

        // Assert
        dnsGeos.IsSuccessful.Should().BeTrue();
        dnsGeos.Content.Should().NotBeNullOrEmpty();
    }
}
namespace MVFC.Connectors.Tests.Geo;

public sealed class GeocodingTests
{
    public static TheoryData<IGeocodingApi> Apis =>
     [
          GeocodingExtensoes.ObterGeocodingApi(),
          TestsHelpers.ObterApi<IGeocodingApi>(s => s.AddGeocoding()),
     ];

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task ObterGeografia_DeveRetornarItemAsync(IGeocodingApi api)
    {
        // Arrange
        const string nomeDaCidade = "Sao Paulo";

        // Act
        var geografia = await api.ObterGeografiaPorNomeDaCidadeAsync(nomeDaCidade);

        // Assert
        geografia.IsSuccessful.Should().BeTrue();
        geografia.Content.Should().NotBeNull();
    }
}
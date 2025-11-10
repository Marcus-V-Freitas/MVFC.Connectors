namespace MVFC.Connectors.Tests.BrasilApi;

public sealed class NcmTests
{
    public static TheoryData<INcmBrasilApi> Apis =>
      [
          NcmBrasilApiExtensoes.ObterNcmBrasilApi(),
          TestsHelpers.ObterApi<INcmBrasilApi>(s => s.AddNcmBrasilApi()),
       ];

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task GetNcmsAsync_DeveRetornarListaDeNcm(INcmBrasilApi api)
    {
        // Arrange & Act
        var ncms = await api.GetNcmsAsync();

        // Assert
        ncms.IsSuccessStatusCode.Should().BeTrue();
        ncms.Content.Should().NotBeNull();
    }

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task GetNcmsBySearchCodeAsync_DeveRetornarListaDeNcm(INcmBrasilApi api)
    {
        // Arrange &
        const string code = "0101";

        // Act
        var ncms = await api.GetNcmsBySearchCodeAsync(code);

        // Assert
        ncms.IsSuccessStatusCode.Should().BeTrue();
        ncms.Content.Should().NotBeNull();
    }

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task GetNcmByCodeAsync_DeveRetornarNcm(INcmBrasilApi api)
    {
        // Arrange
        const string code = "0101.2";

        // Act
        var ncm = await api.GetNcmByCodeAsync(code);

        // Assert
        ncm.IsSuccessStatusCode.Should().BeTrue();
        ncm.Content.Should().NotBeNull();
        ncm.Content?.NumeroAto.Should().Be("272");
    }
}
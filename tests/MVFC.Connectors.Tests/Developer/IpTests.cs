namespace MVFC.Connectors.Tests.Developer;

public sealed class IpTests
{
    public static TheoryData<IIpApi> Apis =>
     [
          IpApiExtensoes.ObterIpApi(),
          TestsHelpers.ObterApi<IIpApi>(s => s.AddIp()),
       ];

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task ObterPhishing_DeveRetornarItemAsync(IIpApi api)
    {
        // Arrange
        const string numero = "52.46.64.223";

        // Act
        var ip = await api.ObterIpPorNumeroAsync(numero);

        // Assert
        ip.IsSuccessful.Should().BeTrue();
        ip.Content.Should().NotBeNull();
    }
}
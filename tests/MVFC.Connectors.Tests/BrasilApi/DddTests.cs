namespace MVFC.Connectors.Tests.BrasilApi;

public sealed class DddTests
{
    public static TheoryData<IDddBrasilApi> Apis =>
        new()
        {
            DddBrasilApiExtensoes.ObterDddBrasilApi(),
            TestsHelpers.ObterApi<IDddBrasilApi>(s => s.AddDddBrasilApi()),
        };

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task RecuperarDdd_DeveRetornarItens(IDddBrasilApi api)
    {
        // Arrange &
        const string codigoDdd = "55";

        // Act
        var dddInfo = await api.ObterDddInfoPorCodigoAsync(codigoDdd);

        // Assert
        dddInfo.IsSuccessful.Should().BeTrue();
        dddInfo.Content.Should().NotBeNull();
        dddInfo.Content?.Cities.Should().NotBeEmpty();
    }
}
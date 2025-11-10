namespace MVFC.Connectors.Tests.BrasilApi;

public sealed class DddTests
{
    public static TheoryData<IDddBrasilApi> Apis =>
        [
            DddBrasilApiExtensoes.ObterDddBrasilApi(),
            TestsHelpers.ObterApi<IDddBrasilApi>(s => s.AddDddBrasilApi()),
        ];

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task RecuperarDdd_DeveRetornarItens(IDddBrasilApi api)
    {
        // Arrange &
        const string ddd = "55";

        // Act
        var dddInfo = await api.GetDddInfoAsync(ddd);

        // Assert
        dddInfo.IsSuccessful.Should().BeTrue();
        dddInfo.Content.Should().NotBeNull();
        dddInfo.Content?.Cities.Should().NotBeEmpty();
    }
}
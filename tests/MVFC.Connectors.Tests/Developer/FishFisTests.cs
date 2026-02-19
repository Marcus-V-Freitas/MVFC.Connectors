namespace MVFC.Connectors.Tests.Developer;

public sealed class FishFisTests
{
    public static TheoryData<IFishFishApi> Apis =>
        new()
        {
            { FishFishExtensoes.ObterFishFishApi() },
            { TestsHelpers.ObterApi<IFishFishApi>(s => s.AddFishFish()) },
        };

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task ObterPhishing_DeveRetornarItemAsync(IFishFishApi api)
    {
        // Arrange & Act
        var phishing = await api.ObterPhishingAsync();

        // Assert
        phishing.IsSuccessful.Should().BeTrue();
        phishing.Content.Should().NotBeNullOrEmpty();
    }
}
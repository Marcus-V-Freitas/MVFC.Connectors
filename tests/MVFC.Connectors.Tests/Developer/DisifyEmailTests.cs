namespace MVFC.Connectors.Tests.Developer;

public sealed class DisifyEmailTests
{
    public static TheoryData<IDisifyEmailApi> Apis =>
    new()
    {
        { DisifyEmailApiExtensoes.ObterDisifyEmailApi() },
        { TestsHelpers.ObterApi<IDisifyEmailApi>(s => s.AddDisifyEmail()) },
    };

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task VerificarStatusEmail_DeveRetornarItemAsync(IDisifyEmailApi api)
    {
        // Arrange
        const string email = "teste@teste.com";

        // Act
        var emailStatus = await api.VerificarValidadeDoEmailAsync(email);

        // Assert
        emailStatus.IsSuccessful.Should().BeTrue();
        emailStatus.Content.Should().NotBeNull();
        emailStatus.Content!.Disposable.Should().BeTrue();
    }
}
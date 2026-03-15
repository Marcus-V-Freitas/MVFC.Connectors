namespace MVFC.Connectors.Tests.Developer;

public sealed class DisifyEmailTests : ConnectorTestsBase<IDisifyEmailApi>
{
    protected override IDisifyEmailApi ManualApi => DisifyEmailApiExtensoes.ObterDisifyEmailApi();

    protected override IDisifyEmailApi ServiceCollectionApi => TestsHelpers.ObterApi<IDisifyEmailApi>(s => s.AddDisifyEmail());

    public static TheoryData<RegistrationMode> Modes => [RegistrationMode.Manual, RegistrationMode.ServiceCollection];

    [Theory]
    [MemberData(nameof(Modes))]
    public Task GarantirQueApiEstaConfiguradaEBuscandoDados(RegistrationMode mode) =>
        ValidarConfiguracaoApi(mode);

    protected override Task ExecutarChamadaBasica(IDisifyEmailApi api) =>
        api.VerificarValidadeDoEmailAsync("teste@teste.com");

    [Fact]
    public async Task VerificarStatusEmail_DeveRetornarItemAsync()
    {
        // Arrange
        const string EMAIL = "teste@teste.com";

        // Act
        var emailStatus = await ManualApi.VerificarValidadeDoEmailAsync(EMAIL);

        // Assert
        emailStatus.IsSuccessful.Should().BeTrue();
        emailStatus.Content.Should().NotBeNull();
        emailStatus.Content!.Disposable.Should().BeTrue();
    }
}

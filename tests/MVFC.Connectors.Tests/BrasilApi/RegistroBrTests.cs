namespace MVFC.Connectors.Tests.BrasilApi;

public sealed class RegistroBrTests : ConnectorTestsBase<IRegistroBrApi>
{
    protected override IRegistroBrApi ManualApi => RegistroBrBrasilApiExtensoes.ObterRegistroBrBrasilApi();

    protected override IRegistroBrApi ServiceCollectionApi => TestsHelpers.ObterApi<IRegistroBrApi>(s => s.AddRegistroBrBrasilApi());

    public static TheoryData<RegistrationMode> Modes => [RegistrationMode.Manual, RegistrationMode.ServiceCollection];

    [Theory]
    [MemberData(nameof(Modes))]
    public Task GarantirQueApiEstaConfiguradaEBuscandoDados(RegistrationMode mode) =>
        ValidarConfiguracaoApi(mode);

    protected override Task ExecutarChamadaBasica(IRegistroBrApi api) =>
        api.VerificarStatusDoDominioAsync("marcus");

    [Fact]
    public async Task RecuperarRegistroBrPorDominio_DeveRetornarItens()
    {
        // Arrange
        const string DOMINIO = "google";

        // Act
        var registro = await ManualApi.VerificarStatusDoDominioAsync(DOMINIO);

        // Assert
        registro.IsSuccessful.Should().BeTrue();
        registro.Content.Should().NotBeNull();
        registro.Content?.Status.Should().Be("REGISTERED");
    }
}

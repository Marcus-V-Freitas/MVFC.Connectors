namespace MVFC.Connectors.Tests.BrasilApi;

public sealed class DddTests : ConnectorTestsBase<IDddBrasilApi>
{
    protected override IDddBrasilApi ManualApi => DddBrasilApiExtensoes.ObterDddBrasilApi();

    protected override IDddBrasilApi ServiceCollectionApi => TestsHelpers.ObterApi<IDddBrasilApi>(s => s.AddDddBrasilApi());

    public static TheoryData<RegistrationMode> Modes => [RegistrationMode.Manual, RegistrationMode.ServiceCollection];

    [Theory]
    [MemberData(nameof(Modes))]
    public Task GarantirQueApiEstaConfiguradaEBuscandoDados(RegistrationMode mode) =>
        ValidarConfiguracaoApi(mode);

    protected override Task ExecutarChamadaBasica(IDddBrasilApi api) =>
        api.ObterDddInfoPorCodigoAsync("55");

    [Fact]
    public async Task RecuperarDdd_DeveRetornarItens()
    {
        // Arrange &
        const string CODIGO_DDD = "55";

        // Act
        var dddInfo = await ManualApi.ObterDddInfoPorCodigoAsync(CODIGO_DDD);

        // Assert
        dddInfo.IsSuccessful.Should().BeTrue();
        dddInfo.Content.Should().NotBeNull();
        dddInfo.Content?.Cities.Should().NotBeEmpty();
    }
}

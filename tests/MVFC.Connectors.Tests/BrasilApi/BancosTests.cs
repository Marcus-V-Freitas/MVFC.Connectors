namespace MVFC.Connectors.Tests.BrasilApi;

public sealed class BancosTests : ConnectorTestsBase<IBancoBrasilApi>
{
    protected override IBancoBrasilApi ManualApi => BancosBrasilApiExtensoes.ObterBankBrasilApi();

    protected override IBancoBrasilApi ServiceCollectionApi => TestsHelpers.ObterApi<IBancoBrasilApi>(s => s.AddBankBrasilApi());

    public static TheoryData<RegistrationMode> Modes => [RegistrationMode.Manual, RegistrationMode.ServiceCollection];

    [Theory]
    [MemberData(nameof(Modes))]
    public Task GarantirQueApiEstaConfiguradaEBuscandoDados(RegistrationMode mode) =>
        ValidarConfiguracaoApi(mode);

    protected override Task ExecutarChamadaBasica(IBancoBrasilApi api) =>
        api.ObterBancosAsync();

    [Fact]
    public async Task RecuperarTodosOsBancos_DeveRetornarItens()
    {
        // Arrange & Act
        var bancos = await ManualApi.ObterBancosAsync();

        // Assert
        bancos.IsSuccessful.Should().BeTrue();
        bancos.Content.Should().NotBeNull();
    }

    [Fact]
    public async Task RecuperarBancoPorCodigo_DeveRetornarItem()
    {
        // Arrange
        const int CODIGO = 1;

        // Act
        var banco = await ManualApi.ObterBancosPorCodigoAsync(CODIGO);

        // Assert
        banco.IsSuccessful.Should().BeTrue();
        banco.Content?.Name.Should().Be("BCO DO BRASIL S.A.");
    }
}

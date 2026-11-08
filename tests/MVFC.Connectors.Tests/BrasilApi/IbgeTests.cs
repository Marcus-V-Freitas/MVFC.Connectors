namespace MVFC.Connectors.Tests.BrasilApi;

public sealed class IbgeTests : ConnectorTestsBase<IIbgeBrasilApi>
{
    private readonly IReadOnlyList<IbgeProvedor> _provedores =
        [
            IbgeProvedor.DadosAbertos,
            IbgeProvedor.Gov,
            IbgeProvedor.Wikipedia,
        ];

    protected override IIbgeBrasilApi ManualApi => IbgeBrasilApiExtensoes.ObterIbgeBrasilApi();

    protected override IIbgeBrasilApi ServiceCollectionApi => TestsHelpers.ObterApi<IIbgeBrasilApi>(s => s.AddIbgeBrasilApi());

    public static TheoryData<RegistrationMode> Modes => [RegistrationMode.Manual, RegistrationMode.ServiceCollection];

    [Theory]
    [MemberData(nameof(Modes))]
    public Task GarantirQueApiEstaConfiguradaEBuscandoDados(RegistrationMode mode) =>
        ValidarConfiguracaoApi(mode);

    protected override Task ExecutarChamadaBasica(IIbgeBrasilApi api) =>
        api.ObterEstadosAsync();

    [Fact]
    public async Task RecuperarMunicipiosUfs_DeveRetornarItens()
    {
        // Arrange
        const IbgeSiglaUf SIGLA_UF = IbgeSiglaUf.SP;

        //Act
        var municipios = await ManualApi.ObterMunicipiosPorUfAsync(SIGLA_UF, _provedores);

        // Assert
        Assert.SkipUnless(municipios.IsSuccessful, $"IBGE Municípios: {municipios.Error?.Message}");
        municipios.Content.Should().NotBeNullOrEmpty();

        // Arrange & Act
        var ufs = await ManualApi.ObterEstadosAsync();

        // Assert
        Assert.SkipUnless(ufs.IsSuccessful, $"IBGE UFs: {ufs.Error?.Message}");
        ufs.Content.Should().NotBeNullOrEmpty();
    }
}

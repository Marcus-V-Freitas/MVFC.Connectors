namespace MVFC.Connectors.Tests.BancoData;

public sealed class BancoDataTratadoTests : ConnectorTestsBase<IBancoDataTratadoApi>
{
    protected override IBancoDataTratadoApi ManualApi => BancoDataTratadoExtensoes.ObterBancoTratadoApi();

    protected override IBancoDataTratadoApi ServiceCollectionApi => TestsHelpers.ObterApi<IBancoDataTratadoApi>(s => s.AddBancoDataTratado());

    public static TheoryData<RegistrationMode> Modes => [RegistrationMode.Manual, RegistrationMode.ServiceCollection];

    [Theory]
    [MemberData(nameof(Modes))]
    public Task GarantirQueApiEstaConfiguradaEBuscandoDados(RegistrationMode mode) =>
        ValidarConfiguracaoApi(mode);

    protected override Task ExecutarChamadaBasica(IBancoDataTratadoApi api) =>
        api.ObterDadosTratadosAsync("master");

    [Fact]
    public async Task DadosTratados_DeveRetornarItemAsync()
    {
        // Arrange
        const string BANK_CODE = "master";

        // Act
        var dadosTratados = await ManualApi.ObterDadosTratadosAsync(BANK_CODE);

        // Assert
        dadosTratados.IsSuccessStatusCode.Should().BeTrue();
        dadosTratados.Content.Should().NotBeNull();
        dadosTratados.Content!.Codigo.Should().BeEquivalentTo(BANK_CODE);
    }
}

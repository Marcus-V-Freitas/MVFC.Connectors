namespace MVFC.Connectors.Tests.Justica;

public sealed class DataJudTests : ConnectorTestsBase<IDataJudApi>
{
    protected override IDataJudApi ManualApi => DataJudExtensoes.ObterDataJudApi();

    protected override IDataJudApi ServiceCollectionApi => TestsHelpers.ObterApi<IDataJudApi>(s => s.AddDataJud());

    public static TheoryData<RegistrationMode> Modes => [RegistrationMode.Manual, RegistrationMode.ServiceCollection];

    [Theory]
    [MemberData(nameof(Modes))]
    public Task GarantirQueApiEstaConfiguradaEBuscandoDados(RegistrationMode mode) =>
        ValidarConfiguracaoApi(mode);

    protected override Task ExecutarChamadaBasica(IDataJudApi api) =>
        api.ObterProcessosPorNumeroAsync(DataJudTribunal.TRF1, DataJudProcessoRequest.CriarPorNumero("00001794219724013300"));

    [Fact]
    public async Task ObterDataJudProcesso_DeveRetornarItemAsync()
    {
        // Arrange
        const DataJudTribunal TRIBUNAL = DataJudTribunal.TRF1;
        const string NUMERO_PROCESSO = "00001794219724013300";
        var request = DataJudProcessoRequest.CriarPorNumero(NUMERO_PROCESSO);

        // Act
        var processoDataJud = await ManualApi.ObterProcessosPorNumeroAsync(TRIBUNAL, request);

        // Assert
        processoDataJud.IsSuccessful.Should().BeTrue();
        processoDataJud.Content.Should().NotBeNull();
        processoDataJud.Content!.Hits.Hits[0].Source.NumeroProcesso.Should().Be(NUMERO_PROCESSO);
    }
}

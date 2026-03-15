namespace MVFC.Connectors.Tests.BancoData;

public sealed class BancoDataBrutoTests : ConnectorTestsBase<IBancoDataBrutoApi>
{
    protected override IBancoDataBrutoApi ManualApi => BancoDataBrutoExtensoes.ObterBancoDataBrutoApi();

    protected override IBancoDataBrutoApi ServiceCollectionApi => TestsHelpers.ObterApi<IBancoDataBrutoApi>(s => s.AddBancoDataBruto());

    public static TheoryData<RegistrationMode> Modes => [RegistrationMode.Manual, RegistrationMode.ServiceCollection];

    [Theory]
    [MemberData(nameof(Modes))]
    public Task GarantirQueApiEstaConfiguradaEBuscandoDados(RegistrationMode mode) =>
        ValidarConfiguracaoApi(mode);

    protected override Task ExecutarChamadaBasica(IBancoDataBrutoApi api) =>
        api.ObterDadosBrutosAsync("icbc-do-brasil-bm-sa");

    [Fact]
    public async Task DadosBrutos_DeveRetornarItemAsync()
    {
        // Arrange
        const string BANK_CODE = "icbc-do-brasil-bm-sa";

        // Act
        var dadosBrutos = await ManualApi.ObterDadosBrutosAsync(BANK_CODE);

        // Assert
        dadosBrutos.IsSuccessStatusCode.Should().BeTrue();
        dadosBrutos.Content.Should().NotBeNull();
        dadosBrutos.Content!.Codigo.Should().BeEquivalentTo(BANK_CODE);
    }

    [Fact]   
    public async Task DadosBrutos_BancoInvalido_DeveRetornarErro()
    {
        // Arrange
        const string BANK_CODE = "banco-inexistente-xyz";

        // Act
        var act = async () =>  await ManualApi.ObterDadosBrutosAsync(BANK_CODE).ConfigureAwait(true);

        // Assert
        await act.Should().ThrowAsync<ScraperException>();
    }

    [Fact]
    public async Task DadosBrutos_BancoNaoInformado_DeveRetornarErro()
    {
        // Arrange
        const string BANK_CODE = "";

        // Act
        var act = async () => await ManualApi.ObterDadosBrutosAsync(BANK_CODE).ConfigureAwait(true);

        // Assert
        await act.Should().ThrowAsync<NullReferenceException>();
    }
}

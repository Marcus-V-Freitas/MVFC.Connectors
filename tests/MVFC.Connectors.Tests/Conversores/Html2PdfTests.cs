namespace MVFC.Connectors.Tests.Conversores;

public sealed class Html2PdfTests() : ConnectorTestsBase<IHtml2PdfApi>, IDisposable
{
    private readonly Html2PdfClassFixture _fixture = new();

    protected override IHtml2PdfApi ManualApi => Html2PdfExtensoes.ObterHtml2PdfApi();

    protected override IHtml2PdfApi ServiceCollectionApi => TestsHelpers.ObterApi<IHtml2PdfApi>(s => s.AddHtml2Pdf());

    public static TheoryData<RegistrationMode> Modes => [RegistrationMode.Manual, RegistrationMode.ServiceCollection];

    [Theory]
    [MemberData(nameof(Modes))]
    public Task GarantirQueApiEstaConfiguradaEBuscandoDados(RegistrationMode mode) =>
        ValidarConfiguracaoApi(mode);

    protected override Task ExecutarChamadaBasica(IHtml2PdfApi api) =>
        api.GerarPdfPorHtml(new Html2PdfRequest(Html: "<p>Olá</p>"));


    [Fact]
    public async Task GerarPdfPorHtml_DeveRetornarItemAsync()
    {
        // Arrange
        var pdfGeradoPath = Path.Combine(_fixture.ARQUIVO_PATH, $"{Guid.NewGuid()}.pdf");
        var request = new Html2PdfRequest(Html: "<p>Olá , mundo!</p>");

        // Act
        var pdfGerado = await ManualApi.GerarPdfPorHtml(request);

        // Assert
        _fixture.AssertArquivoGerado(pdfGerado, pdfGeradoPath);
    }

    public void Dispose() =>
        _fixture.Dispose();
}

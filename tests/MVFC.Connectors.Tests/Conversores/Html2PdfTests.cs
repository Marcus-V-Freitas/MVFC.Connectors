namespace MVFC.Connectors.Tests.Conversores;

public sealed class Html2PdfTests : DirectoryHelper
{
    public static TheoryData<IHtml2PdfApi> Apis =>
      [
          Html2PdfExtensoes.ObterHtml2PdfApi(),
          TestsHelpers.ObterApi<IHtml2PdfApi>(s => s.AddHtml2Pdf()),
       ];

    protected override string ARQUIVO_PATH => "temp_folder_html2";

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task GerarPdfPorHtml_DeveRetornarItemAsync(IHtml2PdfApi api)
    {
        // Arrange
        var pdfGeradoPath = Path.Combine(ARQUIVO_PATH, $"{Guid.NewGuid()}.pdf");
        var request = new Html2PdfRequest(Html: "<p>Olá , mundo!</p>");

        // Act
        var pdfGerado = await api.GerarPdfPorHtml(request);

        // Assert
        AssertArquivoGerado(pdfGerado, pdfGeradoPath);
    }
}
namespace MVFC.Connectors.Conversores.Html2Pdf;

public interface IHtml2PdfApi : IConnectorApi
{
    [Post("/generate")]
    Task<ApiResponse<Stream>> GerarPdfPorHtml([Body] Html2PdfRequest request);
}
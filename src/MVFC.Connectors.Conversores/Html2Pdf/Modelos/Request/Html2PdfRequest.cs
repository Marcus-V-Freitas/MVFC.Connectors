namespace MVFC.Connectors.Conversores.Html2Pdf.Modelos.Request;

public sealed record Html2PdfRequest(
    [property: JsonPropertyName("html")] string Html);
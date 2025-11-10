namespace MVFC.Connectors.Conversores.Html2Pdf.Extensoes;

public static class Html2PdfExtensoes
{
    private const string URL_BASE = "https://html2pdf.fly.dev/api";

    public static IHtml2PdfApi ObterHtml2PdfApi() =>
         ExtensoesBase.ObterApi<IHtml2PdfApi>(URL_BASE).Construir();

    public static void AddHtml2Pdf(this IServiceCollection services) =>
        services.AddApi<IHtml2PdfApi>(URL_BASE);
}
namespace MVFC.Connectors.BancoData.Bruto.Scraper;

internal interface IBancoDataScraper
{
    internal Task<BancoBrutoDto> ScrapeAsync(string bankCode, string html);
}

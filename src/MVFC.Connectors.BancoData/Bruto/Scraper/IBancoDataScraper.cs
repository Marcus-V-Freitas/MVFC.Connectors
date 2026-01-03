namespace MVFC.Connectors.BancoData.Bruto.Scraper;

internal interface IBancoDataScraper
{
    Task<BancoBrutoDto> ScrapeAsync(string bankCode, string html);
}
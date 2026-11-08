namespace MVFC.Connectors.BancoData.Bruto.Handlers;

internal sealed class BancoDataBrutoHandler(IBancoDataScraper scraper) : DelegatingHandler
{
    private readonly IBancoDataScraper _scraper = scraper;

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        var bankCode = HelpersExtensoes.ExtrairBankCode(request.RequestUri?.PathAndQuery);

        if (string.IsNullOrEmpty(bankCode))
        {
            return new HttpResponseMessage(HttpStatusCode.BadRequest)
            {
                RequestMessage = request,
            };
        }

        var response = await base.SendAsync(request, cancellationToken).ConfigureAwait(false);

        if (!response.IsSuccessStatusCode)
            return response;

        var html = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
        var dadosBrutos = await _scraper.ScrapeAsync(bankCode, html).ConfigureAwait(false);

        return new HttpResponseMessage(HttpStatusCode.OK)
        {
            Content = HelpersExtensoes.CriarConteudoJson(dadosBrutos),
            RequestMessage = request,
        };
    }
}

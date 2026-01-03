namespace MVFC.Connectors.BancoData.Tratado.Handlers;

internal sealed class BancoDataTratadoHandler(IBancoDataScraper scraper, IBancoDataTransform transform) : DelegatingHandler
{
    private readonly IBancoDataScraper _scraper = scraper;
    private readonly IBancoDataTransform _transform = transform;

    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
        var bankCode = HelpersExtensoes.ExtrairBankCode(request.RequestUri?.PathAndQuery);

        if (string.IsNullOrEmpty(bankCode))
            return new HttpResponseMessage(HttpStatusCode.BadRequest);

        var response = await base.SendAsync(request, cancellationToken);
        var html = await response.Content.ReadAsStringAsync(cancellationToken);
        var dadosBrutos = await _scraper.ScrapeAsync(bankCode, html);
        var dadosTratados = _transform.Transformar(dadosBrutos);

        return new HttpResponseMessage(HttpStatusCode.OK)
        {
            Content = HelpersExtensoes.CriarConteudoJson(dadosTratados),
        };
    }
}
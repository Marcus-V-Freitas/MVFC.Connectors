namespace MVFC.Connectors.Tests.Sicoob;

public sealed class SicoobCobrancaBancariaTests : ConnectorTestsBase<ISicoobCobrancaBancariaApi>
{
    protected override ISicoobCobrancaBancariaApi ManualApi => SicoobCobrancaBancariaExtensoes.ObterSicoobCobrancaBancariaApi(SicoobBaseTests.Config);

    protected override ISicoobCobrancaBancariaApi ServiceCollectionApi => TestsHelpers.ObterApi<ISicoobCobrancaBancariaApi>(s => s.AddSicoobCobrancaBancaria(SicoobBaseTests.Config));

    public static TheoryData<RegistrationMode> Modes => [RegistrationMode.Manual, RegistrationMode.ServiceCollection];

    [Theory]
    [MemberData(nameof(Modes))]
    public Task GarantirQueApiEstaConfiguradaEBuscandoDados(RegistrationMode mode) =>
        ValidarConfiguracaoApi(mode);

    protected override Task ExecutarChamadaBasica(ISicoobCobrancaBancariaApi api) =>
        api.ConsultarBoletoAsync(new BoletoConsultaQuery(25546454, ModalidadeBoleto.SimplesComRegistro));

    [Fact]
    public async Task IncluirBoletoAsync_DeveRetornarSucessoAsync()
    {
        // Arrange
        var request = await SicoobBaseTests.ObterPorArquivoAsync<BoletoRequest>("CobrancaBancaria", "BoletoRequest.json");

        // Act
        var response = await ManualApi.IncluirBoletoAsync(request!);
        
         // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
    }

    [Fact]
    public async Task ConsultarBoletoAsync_DeveRetornarSucessoAsync()
    {
        // Arrange
        var query = new BoletoConsultaQuery(25546454, ModalidadeBoleto.SimplesComRegistro);

        // Act
        var response = await ManualApi.ConsultarBoletoAsync(query);

        // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
    }

    [Fact]
    public async Task ListarBoletosPorPagadorAsync_DeveRetornarSucessoAsync()
    {
        // Arrange
        var query = new BoletoConsultarPagadorQuery(25546454);

        // Act
        var response = await ManualApi.ListarBoletosPorPagadorAsync("11122233300", query);

        // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
        response.Content!.Resultado.Should().NotBeNullOrEmpty();
    }

    [Fact]
    public async Task EmitirSegundaViaAsync_DeveRetornarSucessoAsync()
    {
        // Arrange
        var query = new BoletoSegundaViaQuery(25546454, ModalidadeBoleto.SimplesComRegistro);

        // Act
        var response = await ManualApi.EmitirSegundaViaAsync(query);

        // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
    }

    [Fact]
    public async Task ConsultarFaixasNossoNumeroAsync_DeveRetornarSucessoAsync()
    {
        // Arrange
        var query = new BoletoConsultarFaixaQuery(25546454, ModalidadeBoleto.SimplesComRegistro, 1);

        // Act
        var response = await ManualApi.ConsultarFaixasNossoNumeroAsync(query);

        // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
    }

    [Fact]
    public async Task AlterarBoletoAsync_DeveRetornarSucessoAsync()
    {
        // Arrange
        var request = new BoletoAlteracaoRequest(25546454, ModalidadeBoleto.SimplesComRegistro)
        {
            Pix = new(true),
        };

        // Act
        var response = await ManualApi.AlterarBoletoAsync(-2147483648, request);

        // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
    }

    [Fact]
    public async Task BaixarBoletoAsync_DeveRetornarSucessoAsync()
    {
        // Arrange
        var request = new BoletoBaixaRequest(25546454, ModalidadeBoleto.SimplesComRegistro);

        // Act
        var response = await ManualApi.BaixarBoletoAsync(-2147483648, request);

        // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
    }

    [Fact]
    public async Task AlterarPagadorAsync_DeveRetornarSucessoAsync()
    {
        // Arrange
        var request = await SicoobBaseTests.ObterPorArquivoAsync<PagadorRequest>("CobrancaBancaria", "PagadorRequest.json");

        // Act
        var response = await ManualApi.AlterarPagadorAsync(request);

        // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
    }

    [Fact]
    public async Task NegativarBoletoAsync_DeveRetornarSucessoAsync()
    {
        // Arrange
        var request = new NegativacaoRequest(25546454, ModalidadeBoleto.SimplesComRegistro);

        // Act
        var response = await ManualApi.NegativarBoletoAsync(-2147483648, request);

        // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
    }

    [Fact]
    public async Task CancelarNegativacaoAsync_DeveRetornarSucessoAsync()
    {
        // Arrange
        var request = new NegativacaoRequest(25546454, ModalidadeBoleto.SimplesComRegistro);

        // Act
        var response = await ManualApi.CancelarNegativacaoAsync(-2147483648, request);

        // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
    }

    [Fact]
    public async Task BaixarNegativacaoAsync_DeveRetornarSucessoAsync()
    {
        // Arrange
        var request = new NegativacaoRequest(25546454, ModalidadeBoleto.SimplesComRegistro);

        // Act
        var response = await ManualApi.BaixarNegativacaoAsync(-2147483648, request);

        // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
    }

    [Fact]
    public async Task ProtestarBoletoAsync_DeveRetornarSucessoAsync()
    {
        // Arrange
        var request = new ProtestoRequest(25546454, ModalidadeBoleto.SimplesComRegistro);

        // Act
        var response = await ManualApi.ProtestarBoletoAsync(-2147483648, request);

        // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
    }

    [Fact]
    public async Task CancelarProtestoAsync_DeveRetornarSucessoAsync()
    {
        // Arrange
        var request = new ProtestoRequest(25546454, ModalidadeBoleto.SimplesComRegistro);

        // Act
        var response = await ManualApi.CancelarProtestoAsync(-2147483648, request);

        // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
    }

    [Fact]
    public async Task DesistirProtestoAsync_DeveRetornarSucessoAsync()
    {
        // Arrange
        var request = new ProtestoRequest(25546454, ModalidadeBoleto.SimplesComRegistro);

        // Act
        var response = await ManualApi.DesistirProtestoAsync(-2147483648, request);

        // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
    }

    [Fact]
    public async Task SolicitarMovimentacaoAsync_DeveRetornarSucessoAsync()
    {
        // Arrange
        var request = await SicoobBaseTests.ObterPorArquivoAsync<MovimentacaoRequest>("CobrancaBancaria", "MovimentacaoRequest.json");

        // Act
        var response = await ManualApi.SolicitarMovimentacaoAsync(request);

        // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
    }

    [Fact]
    public async Task DownloadMovimentacaoAsync_DeveRetornarSucessoAsync()
    {
        // Arrange
        var query = new DownloadMovimentacaoQuery(25546454, 132, 30025254);

        // Act
        var response = await ManualApi.DownloadMovimentacaoAsync(query);

        // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
    }

    [Fact]
    public async Task ConsultarMovimentacaoAsync_DeveRetornarSucessoAsync()
    {
        // Arrange
        var query = new ConsultarMovimentacaoQuery(25546454, 132);

        // Act
        var response = await ManualApi.ConsultarMovimentacaoAsync(query);

        // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
    }

    [Fact]
    public async Task CadastrarWebhookAsync_DeveRetornarSucessoAsync()
    {
        // Arrange
        var request = await SicoobBaseTests.ObterPorArquivoAsync<WebhookCBCadastroRequest>("CobrancaBancaria", "WebhookRequest.json");

        // Act
        var response = await ManualApi.CadastrarWebhookAsync(request!);

        // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
    }

    [Fact]
    public async Task ConsultarWebhooksAsync_DeveRetornarSucessoAsync()
    {
        // Arrange
        var query = new CobrancaWebhookConsultarQuery(1234);

        // Act
        var response = await ManualApi.ConsultarWebhooksAsync(query);

        // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
    }

    [Fact]
    public async Task AtualizarWebhookAsync_DeveRetornarSucessoAsync()
    {
        // Arrange
        var request = new WebhookCBAlteracaoRequest("https://webhook.com");

        // Act
        var response = await ManualApi.AtualizarWebhookAsync(1234, request);

        // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
    }

    [Fact]
    public async Task ExcluirWebhookAsync_DeveRetornarSucessoAsync()
    {
        // Arrange
        const long ID_WEBHOOK = 1234;

        // Act
        var response = await ManualApi.ExcluirWebhookAsync(ID_WEBHOOK);

        // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
    }

    [Fact]
    public async Task ReativarWebhookAsync_DeveRetornarSucessoAsync()
    {
        // Arrange
        const long ID_WEBHOOK = 1234;

        // Act
        var response = await ManualApi.ReativarWebhookAsync(ID_WEBHOOK);

        // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
    }

    [Fact]
    public async Task ConsultarSolicitacoesWebhookAsync_DeveRetornarSucessoAsync()
    {
        // Arrange
        const long ID_WEBHOOK = 1234;
        var query = new SolicitacaoWebhookConsultaQuery(new DateOnly(2024, 09, 03));

        // Act
        var response = await ManualApi.ConsultarSolicitacoesWebhookAsync(ID_WEBHOOK, query);

        // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
    }
}

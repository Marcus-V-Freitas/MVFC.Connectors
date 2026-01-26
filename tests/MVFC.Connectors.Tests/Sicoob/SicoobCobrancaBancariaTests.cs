namespace MVFC.Connectors.Tests.Sicoob;

public sealed class SicoobCobrancaBancariaTests : SicoobBaseTests
{
    public static TheoryData<ISicoobCobrancaBancariaApi> Apis =>
     [
          SicoobCobrancaBancariaExtensoes.ObterSicoobCobrancaBancariaApi(_config),
          TestsHelpers.ObterApi<ISicoobCobrancaBancariaApi>(s => s.AddSicoobCobrancaBancaria(_config)),
       ];

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task IncluirBoletoAsync_DeveRetornarSucessoAsync(ISicoobCobrancaBancariaApi api)
    {
        // Arrange
        var request = await ObterPorArquivoAsync<BoletoRequest>("CobrancaBancaria", "BoletoRequest.json");

        // Act
        var response = await api.IncluirBoletoAsync(request!);
        
         // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
    }

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task ConsultarBoletoAsync_DeveRetornarSucessoAsync(ISicoobCobrancaBancariaApi api)
    {
        // Arrange
        var query = new BoletoConsultaQuery(25546454, ModalidadeBoleto.SimplesComRegistro);

        // Act
        var response = await api.ConsultarBoletoAsync(query);

        // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
    }

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task ListarBoletosPorPagadorAsync_DeveRetornarSucessoAsync(ISicoobCobrancaBancariaApi api)
    {
        // Arrange
        var query = new BoletoConsultarPagadorQuery(25546454);

        // Act
        var response = await api.ListarBoletosPorPagadorAsync("11122233300", query);

        // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
        response.Content!.Resultado.Should().NotBeNullOrEmpty();
    }

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task EmitirSegundaViaAsync_DeveRetornarSucessoAsync(ISicoobCobrancaBancariaApi api)
    {
        // Arrange
        var query = new BoletoSegundaViaQuery(25546454, ModalidadeBoleto.SimplesComRegistro);

        // Act
        var response = await api.EmitirSegundaViaAsync(query);

        // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
    }

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task ConsultarFaixasNossoNumeroAsync_DeveRetornarSucessoAsync(ISicoobCobrancaBancariaApi api)
    {
        // Arrange
        var query = new BoletoConsultarFaixaQuery(25546454, ModalidadeBoleto.SimplesComRegistro, 1);

        // Act
        var response = await api.ConsultarFaixasNossoNumeroAsync(query);

        // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
    }

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task AlterarBoletoAsync_DeveRetornarSucessoAsync(ISicoobCobrancaBancariaApi api)
    {
        // Arrange
        var request = new BoletoAlteracaoRequest(25546454, ModalidadeBoleto.SimplesComRegistro)
        {
            Pix = new(true),
        };

        // Act
        var response = await api.AlterarBoletoAsync(-2147483648, request);

        // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
    }

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task BaixarBoletoAsync_DeveRetornarSucessoAsync(ISicoobCobrancaBancariaApi api)
    {
        // Arrange
        var request = new BoletoBaixaRequest(25546454, ModalidadeBoleto.SimplesComRegistro);

        // Act
        var response = await api.BaixarBoletoAsync(-2147483648, request);

        // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
    }

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task AlterarPagadorAsync_DeveRetornarSucessoAsync(ISicoobCobrancaBancariaApi api)
    {
        // Arrange
        var request = await ObterPorArquivoAsync<PagadorRequest>("CobrancaBancaria", "PagadorRequest.json");

        // Act
        var response = await api.AlterarPagadorAsync(request);

        // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
    }

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task NegativarBoletoAsync_DeveRetornarSucessoAsync(ISicoobCobrancaBancariaApi api)
    {
        // Arrange
        var request = new NegativacaoRequest(25546454, ModalidadeBoleto.SimplesComRegistro);

        // Act
        var response = await api.NegativarBoletoAsync(-2147483648, request);

        // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
    }

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task CancelarNegativacaoAsync_DeveRetornarSucessoAsync(ISicoobCobrancaBancariaApi api)
    {
        // Arrange
        var request = new NegativacaoRequest(25546454, ModalidadeBoleto.SimplesComRegistro);

        // Act
        var response = await api.CancelarNegativacaoAsync(-2147483648, request);

        // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
    }

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task BaixarNegativacaoAsync_DeveRetornarSucessoAsync(ISicoobCobrancaBancariaApi api)
    {
        // Arrange
        var request = new NegativacaoRequest(25546454, ModalidadeBoleto.SimplesComRegistro);

        // Act
        var response = await api.BaixarNegativacaoAsync(-2147483648, request);

        // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
    }

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task ProtestarBoletoAsync_DeveRetornarSucessoAsync(ISicoobCobrancaBancariaApi api)
    {
        // Arrange
        var request = new ProtestoRequest(25546454, ModalidadeBoleto.SimplesComRegistro);

        // Act
        var response = await api.ProtestarBoletoAsync(-2147483648, request);

        // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
    }

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task CancelarProtestoAsync_DeveRetornarSucessoAsync(ISicoobCobrancaBancariaApi api)
    {
        // Arrange
        var request = new ProtestoRequest(25546454, ModalidadeBoleto.SimplesComRegistro);

        // Act
        var response = await api.CancelarProtestoAsync(-2147483648, request);

        // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
    }

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task DesistirProtestoAsync_DeveRetornarSucessoAsync(ISicoobCobrancaBancariaApi api)
    {
        // Arrange
        var request = new ProtestoRequest(25546454, ModalidadeBoleto.SimplesComRegistro);

        // Act
        var response = await api.DesistirProtestoAsync(-2147483648, request);

        // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
    }

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task SolicitarMovimentacaoAsync_DeveRetornarSucessoAsync(ISicoobCobrancaBancariaApi api)
    {
        // Arrange
        var request = await ObterPorArquivoAsync<MovimentacaoRequest>("CobrancaBancaria", "MovimentacaoRequest.json");

        // Act
        var response = await api.SolicitarMovimentacaoAsync(request);

        // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
    }

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task DownloadMovimentacaoAsync_DeveRetornarSucessoAsync(ISicoobCobrancaBancariaApi api)
    {
        // Arrange
        var query = new DownloadMovimentacaoQuery(25546454, 132, 30025254);

        // Act
        var response = await api.DownloadMovimentacaoAsync(query);

        // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
    }

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task ConsultarMovimentacaoAsync_DeveRetornarSucessoAsync(ISicoobCobrancaBancariaApi api)
    {
        // Arrange
        var query = new ConsultarMovimentacaoQuery(25546454, 132);

        // Act
        var response = await api.ConsultarMovimentacaoAsync(query);

        // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
    }

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task CadastrarWebhookAsync_DeveRetornarSucessoAsync(ISicoobCobrancaBancariaApi api)
    {
        // Arrange
        var request = await ObterPorArquivoAsync<WebhookCBCadastroRequest>("CobrancaBancaria", "WebhookRequest.json");

        // Act
        var response = await api.CadastrarWebhookAsync(request!);

        // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
    }

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task ConsultarWebhooksAsync_DeveRetornarSucessoAsync(ISicoobCobrancaBancariaApi api)
    {
        // Arrange
        var query = new CobrancaWebhookConsultarQuery(1234);

        // Act
        var response = await api.ConsultarWebhooksAsync(query);

        // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
    }

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task AtualizarWebhookAsync_DeveRetornarSucessoAsync(ISicoobCobrancaBancariaApi api)
    {
        // Arrange
        var request = new WebhookCBAlteracaoRequest("https://webhook.com");

        // Act
        var response = await api.AtualizarWebhookAsync(1234, request);

        // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
    }

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task ExcluirWebhookAsync_DeveRetornarSucessoAsync(ISicoobCobrancaBancariaApi api)
    {
        // Arrange
        const long ID_WEBHOOK = 1234;

        // Act
        var response = await api.ExcluirWebhookAsync(ID_WEBHOOK);

        // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
    }

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task ReativarWebhookAsync_DeveRetornarSucessoAsync(ISicoobCobrancaBancariaApi api)
    {
        // Arrange
        const long ID_WEBHOOK = 1234;

        // Act
        var response = await api.ReativarWebhookAsync(ID_WEBHOOK);

        // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
    }

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task ConsultarSolicitacoesWebhookAsync_DeveRetornarSucessoAsync(ISicoobCobrancaBancariaApi api)
    {
        // Arrange
        const long ID_WEBHOOK = 1234;
        var query = new SolicitacaoWebhookConsultaQuery(new DateOnly(2024, 09, 03));

        // Act
        var response = await api.ConsultarSolicitacoesWebhookAsync(ID_WEBHOOK, query);

        // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
    }
}
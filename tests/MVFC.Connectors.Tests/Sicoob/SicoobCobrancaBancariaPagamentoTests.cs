namespace MVFC.Connectors.Tests.Sicoob;

public sealed class SicoobCobrancaBancariaPagamentoTests : SicoobBaseTests
{
    public static TheoryData<ISicoobCobrancaBancariaPagamentoApi> Apis =>
     [
          SicoobCobrancaBancariaPagamentoExtensoes.ObterSicoobCobrancaBancariaPagamentoApi(_config),
          TestsHelpers.ObterApi<ISicoobCobrancaBancariaPagamentoApi>(s => s.AddSicoobCobrancaBancariaPagamento(_config)),
       ];

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task ConsultarBoletosDdaAsync_DeveRetornar_ListaDeBoletos(ISicoobCobrancaBancariaPagamentoApi api)
    {
        // Arrange
        var query = new ConsultarBoletosDdaQuery(NumeroConta: 1234567,
                                                 DataInicial: new(2026, 01, 01),
                                                 DataFinal: new(2026, 01, 31),
                                                 Situacao: SituacaoBoletoPagamento.EmAberto,
                                                 TipoData: TipoData.DataVencimento);

        // Act
        var response = await api.ConsultarBoletosDdaAsync(query);

        // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
    }

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task ConsultarBoletoAsync_ComCodigoBarras_DeveRetornar_DadosDoBoleto(ISicoobCobrancaBancariaPagamentoApi api)
    {
        // Arrange
        var codigoBarras = "34191790010104351004791020150008291070026000";
        var query = new ConsultarBoletoQuery(NumeroConta: 1234567)
        {
            DataPagamento = new DateOnly(2026, 02, 15)
        };

        // Act
        var response = await api.ConsultarBoletoAsync(codigoBarras, query);

        // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
    }

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task PagarBoletoAsync_ComDadosValidos_DeveRetornar_Comprovante(ISicoobCobrancaBancariaPagamentoApi api)
    {
        // Arrange
        var codigoBarras = "34191790010104351004791020150008291070026000";
        var idempotencyKey = $"4342-1234567-{Guid.NewGuid()}";
        var request = await ObterPorArquivoAsync<BoletoPagamentoRequest>("CobrancaBancariaPagamento", "BoletoPagamentoRequest.json");


        // Act
        var response = await api.PagarBoletoAsync(idempotencyKey, codigoBarras, request);

        // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
    }

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task ConsultarComprovanteAsync_ComIdPagamento_DeveRetornar_Comprovante(ISicoobCobrancaBancariaPagamentoApi api)
    {
        // Arrange
        var idPagamento = 987654321L;
        var query = new ConsultarComprovanteQuery(NumeroConta: 1234567);

        // Act
        var response = await api.ConsultarComprovanteAsync(idPagamento, query);

        // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
    }

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task CancelarAgendamentoAsync_ComIdPagamento_DeveCancelar_ComSucesso(ISicoobCobrancaBancariaPagamentoApi api)
    {
        // Arrange
        var idPagamento = 987654321L;
        var cancelamento = new CancelamentoRequest(NumeroConta: 1234567);

        // Act
        var response = await api.CancelarAgendamentoAsync(idPagamento, cancelamento);

        // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
    }

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task ConsultarComprovantePorIdempotencyAsync_ComIdempotency_DeveRetornar_Comprovante(ISicoobCobrancaBancariaPagamentoApi api)
    {
        // Arrange
        var idempotency = $"4342-1234567-{Guid.NewGuid()}";

        // Act
        var response = await api.ConsultarComprovantePorIdempotencyAsync(idempotency);

        // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
    }
}
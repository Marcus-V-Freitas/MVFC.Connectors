namespace MVFC.Connectors.Tests.Sicoob;

public sealed class SicoobCobrancaBancariaPagamentoTests : ConnectorTestsBase<ISicoobCobrancaBancariaPagamentoApi>
{
    protected override ISicoobCobrancaBancariaPagamentoApi ManualApi => SicoobCobrancaBancariaPagamentoExtensoes.ObterSicoobCobrancaBancariaPagamentoApi(SicoobBaseTests.Config);

    protected override ISicoobCobrancaBancariaPagamentoApi ServiceCollectionApi => TestsHelpers.ObterApi<ISicoobCobrancaBancariaPagamentoApi>(s => s.AddSicoobCobrancaBancariaPagamento(SicoobBaseTests.Config));

    public static TheoryData<RegistrationMode> Modes => [RegistrationMode.Manual, RegistrationMode.ServiceCollection];

    [Theory]
    [MemberData(nameof(Modes))]
    public Task GarantirQueApiEstaConfiguradaEBuscandoDados(RegistrationMode mode) =>
        ValidarConfiguracaoApi(mode);

    protected override Task ExecutarChamadaBasica(ISicoobCobrancaBancariaPagamentoApi api) =>
        api.ConsultarBoletosDdaAsync(new ConsultarBoletosDdaQuery(NumeroConta: 1234567,
                                                                 DataInicial: new(2026, 01, 01),
                                                                 DataFinal: new(2026, 01, 31),
                                                                 Situacao: SituacaoBoletoPagamento.EmAberto,
                                                                 TipoData: TipoData.DataVencimento));

    [Fact]
    public async Task ConsultarBoletosDdaAsync_DeveRetornar_ListaDeBoletos()
    {
        // Arrange
        var query = new ConsultarBoletosDdaQuery(NumeroConta: 1234567,
                                                 DataInicial: new(2026, 01, 01),
                                                 DataFinal: new(2026, 01, 31),
                                                 Situacao: SituacaoBoletoPagamento.EmAberto,
                                                 TipoData: TipoData.DataVencimento);

        // Act
        var response = await ManualApi.ConsultarBoletosDdaAsync(query);

        // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
    }

    [Fact]
    public async Task ConsultarBoletoAsync_ComCodigoBarras_DeveRetornar_DadosDoBoleto()
    {
        // Arrange
        const string CODIGO_BARRAS = "34191790010104351004791020150008291070026000";
        var query = new ConsultarBoletoQuery(NumeroConta: 1234567)
        {
            DataPagamento = new DateOnly(2026, 02, 15)
        };

        // Act
        var response = await ManualApi.ConsultarBoletoAsync(CODIGO_BARRAS, query);

        // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
    }

    [Fact]
    public async Task PagarBoletoAsync_ComDadosValidos_DeveRetornar_Comprovante()
    {
        // Arrange
        const string CODIGO_BARRAS = "34191790010104351004791020150008291070026000";
        var idempotencyKey = $"4342-1234567-{Guid.NewGuid()}";
        var request = await SicoobBaseTests.ObterPorArquivoAsync<BoletoPagamentoRequest>("CobrancaBancariaPagamento", "BoletoPagamentoRequest.json");


        // Act
        var response = await ManualApi.PagarBoletoAsync(idempotencyKey, CODIGO_BARRAS, request);

        // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
    }

    [Fact]
    public async Task ConsultarComprovanteAsync_ComIdPagamento_DeveRetornar_Comprovante()
    {
        // Arrange
        const long ID_PAGAMENTO = 987654321L;
        var query = new ConsultarComprovanteQuery(NumeroConta: 1234567);

        // Act
        var response = await ManualApi.ConsultarComprovanteAsync(ID_PAGAMENTO, query);

        // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
    }

    [Fact]
    public async Task CancelarAgendamentoAsync_ComIdPagamento_DeveCancelar_ComSucesso()
    {
        // Arrange
        const long ID_PAGAMENTO = 987654321L;
        var cancelamento = new CancelamentoRequest(NumeroConta: 1234567);

        // Act
        var response = await ManualApi.CancelarAgendamentoAsync(ID_PAGAMENTO, cancelamento);

        // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
    }

    [Fact]
    public async Task ConsultarComprovantePorIdempotencyAsync_ComIdempotency_DeveRetornar_Comprovante()
    {
        // Arrange
        var idempotency = $"4342-1234567-{Guid.NewGuid()}";

        // Act
        var response = await ManualApi.ConsultarComprovantePorIdempotencyAsync(idempotency);

        // Assert
        response.IsSuccessful.Should().BeTrue();
        response.Content.Should().NotBeNull();
    }
}

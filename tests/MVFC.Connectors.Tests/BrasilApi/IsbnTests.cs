namespace MVFC.Connectors.Tests.BrasilApi;

public sealed class IsbnTests : ConnectorTestsBase<IIsbnBrasilApi>
{
    protected override IIsbnBrasilApi ManualApi => IsbnBrasilApiExtensoes.ObterIsbnBrasilApi();

    protected override IIsbnBrasilApi ServiceCollectionApi => TestsHelpers.ObterApi<IIsbnBrasilApi>(s => s.AddIsbnBrasilApi());

    public static TheoryData<RegistrationMode> Modes => [RegistrationMode.Manual, RegistrationMode.ServiceCollection];

    [Theory]
    [MemberData(nameof(Modes))]
    public Task GarantirQueApiEstaConfiguradaEBuscandoDados(RegistrationMode mode) =>
        ValidarConfiguracaoApi(mode);

    protected override Task ExecutarChamadaBasica(IIsbnBrasilApi api) =>
        api.ObterLivroPorIsbnAsync("9788545702870");

    [Fact]
    public async Task RecuperarIsbn_DeveRetornarItens()
    {
        // Arrange
        const string ISBN = "9788545702870";

        // Act
        var livro = await ManualApi.ObterLivroPorIsbnAsync(ISBN);

        // Assert
        livro.IsSuccessful.Should().BeTrue();
        livro.Content.Should().NotBeNull();
    }
}

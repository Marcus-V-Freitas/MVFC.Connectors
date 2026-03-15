namespace MVFC.Connectors.Tests.Developer;

public sealed class KeyValTests : ConnectorTestsBase<IKeyValApi>
{
    protected override IKeyValApi ManualApi => KeyValExtensoes.ObterKeyValApi();

    protected override IKeyValApi ServiceCollectionApi => TestsHelpers.ObterApi<IKeyValApi>(s => s.AddKeyVal());

    public static TheoryData<RegistrationMode> Modes => [RegistrationMode.Manual, RegistrationMode.ServiceCollection];

    [Theory]
    [MemberData(nameof(Modes))]
    public Task GarantirQueApiEstaConfiguradaEBuscandoDados(RegistrationMode mode) =>
        ValidarConfiguracaoApi(mode);

    protected override Task ExecutarChamadaBasica(IKeyValApi api) =>
        api.AdicionarChaveAsync(Guid.NewGuid().ToString(), "valor_teste");

    [Fact]
    public async Task ObterKeyVal_DeveRetornarItemAsync()
    {
        // Arrange
        var chave = Guid.NewGuid().ToString();
        const string VALOR = "valor_teste";

        // Act
        var chaveGerada = await ManualApi.AdicionarChaveAsync(chave, VALOR);

        // Assert
        chaveGerada.IsSuccessful.Should().BeTrue();
        chaveGerada.Content.Should().NotBeNull();
        chaveGerada.Content!.Val.Should().Be(VALOR);

        // Act
        var chaveObtida = await ManualApi.ObterChaveAsync(chave);

        // Assert
        chaveObtida.IsSuccessful.Should().BeTrue();
        chaveObtida.Content.Should().NotBeNull();
        chaveObtida.Content!.Val.Should().Be(VALOR);
    }
}

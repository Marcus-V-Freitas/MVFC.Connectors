namespace MVFC.Connectors.Tests.BrasilApi;

public sealed class BancosTests
{
    public static TheoryData<IBancoBrasilApi> Apis =>
        new()
        {
            BancosBrasilApiExtensoes.ObterBankBrasilApi(),
            TestsHelpers.ObterApi<IBancoBrasilApi>(s => s.AddBankBrasilApi()),
        };

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task RecuperarTodosOsBancos_DeveRetornarItens(IBancoBrasilApi api)
    {
        // Arrange & Act
        var bancos = await api.ObterBancosAsync();

        // Assert
        bancos.IsSuccessful.Should().BeTrue();
        bancos.Content.Should().NotBeNull();
    }

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task RecuperarBancoPorCodigo_DeveRetornarItem(IBancoBrasilApi api)
    {
        // Arrange
        const int codigo = 1;

        // Act
        var banco = await api.ObterBancosPorCodigoAsync(codigo);

        // Assert
        banco.IsSuccessful.Should().BeTrue();
        banco.Content?.Name.Should().Be("BCO DO BRASIL S.A.");
    }
}
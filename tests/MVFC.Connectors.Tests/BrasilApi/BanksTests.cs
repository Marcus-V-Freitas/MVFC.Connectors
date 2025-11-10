namespace MVFC.Connectors.Tests.BrasilApi;

public sealed class BanksTests
{
    public static TheoryData<IBankBrasilApi> Apis =>
        [
            BanksBrasilApiExtensoes.ObterBankBrasilApi(),
            TestsHelpers.ObterApi<IBankBrasilApi>(s => s.AddBankBrasilApi()),
        ];

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task RecuperarTodosOsBancos_DeveRetornarItens(IBankBrasilApi api)
    {
        // Arrange & Act
        var bancos = await api.GetBanksAsync();

        // Assert
        bancos.IsSuccessful.Should().BeTrue();
        bancos.Content.Should().NotBeNull();
    }

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task RecuperarBancoPorCodigo_DeveRetornarItem(IBankBrasilApi api)
    {
        // Arrange
        const int codigo = 1;

        // Act
        var banco = await api.GetBankByCodeAsync(codigo);

        // Assert
        banco.IsSuccessful.Should().BeTrue();
        banco.Content?.Name.Should().Be("BCO DO BRASIL S.A.");
    }
}
namespace MVFC.Connectors.Tests.BrasilApi;

public sealed class CorretorasTests
{
    public static TheoryData<ICorretoraBrasilApi> Apis =>
        [
            CorretorasBrasilApiExtensoes.ObterCorretoraBrasilApi(),
            TestsHelpers.ObterApi<ICorretoraBrasilApi>(s => s.AddCorretoraBrasilApi()),
        ];

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task RecuperarTodasAsCorretoras_DeveRetornarItens(ICorretoraBrasilApi api)
    {
        // Arrange & Act
        var corretoras = await api.GetCorretorasAsync();

        // Assert
        corretoras.IsSuccessful.Should().BeTrue();
        corretoras.Content.Should().NotBeNull();
    }

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task RecuperarCorretoraPorCnpj_DeveRetornarItem(ICorretoraBrasilApi api)
    {
        // Arrange
        const string cnpj = "02332886000104";

        // Act
        var corretora = await api.GetCorretoraByCnpjAsync(cnpj);

        // Assert
        corretora.IsSuccessful.Should().BeTrue();
        corretora.Content?.NomeComercial.Should().Be("XP INVESTIMENTOS");
    }
}
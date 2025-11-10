namespace MVFC.Connectors.Tests.BrasilApi;

public sealed class CnpjTests
{
    public static TheoryData<ICnpjBrasilApi> Apis =>
        [
            CnpjBrasilApiExtensoes.ObterCnpjBrasilApi(),
            TestsHelpers.ObterApi<ICnpjBrasilApi>(s => s.AddCnpjBrasilApi()),
        ];

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task RecuperarCNPJ_DeveRetornarDadosCorretos(ICnpjBrasilApi api)
    {
        // Arrange &
        const string cnpj = "07174743000399";

        // Act
        var resultado = await api.ObterEmpresaPorCnpjAsync(cnpj);

        // Assert
        resultado.IsSuccessful.Should().BeTrue();
        resultado.Content.Should().NotBeNull();
        resultado.Content?.RazaoSocial.Should().Be("GFT BRASIL CONSULTORIA INFORMATICA LTDA.");
    }
}
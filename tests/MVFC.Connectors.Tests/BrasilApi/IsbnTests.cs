namespace MVFC.Connectors.Tests.BrasilApi;

public sealed class IsbnTests
{
    public static TheoryData<IIsbnBrasilApi> Apis =>
        new()
        {
            { IsbnBrasilApiExtensoes.ObterIsbnBrasilApi() },
            { TestsHelpers.ObterApi<IIsbnBrasilApi>(s => s.AddIsbnBrasilApi()) },
        };

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task RecuperarIsbn_DeveRetornarItens(IIsbnBrasilApi api)
    {
        // Arrange
        const string isbn = "9788545702870";

        // Act
        var livro = await api.ObterLivroPorIsbnAsync(isbn);

        // Assert
        livro.IsSuccessful.Should().BeTrue();
        livro.Content.Should().NotBeNull();
    }
}
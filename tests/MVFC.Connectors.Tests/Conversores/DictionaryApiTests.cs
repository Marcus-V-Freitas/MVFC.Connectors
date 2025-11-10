namespace MVFC.Connectors.Tests.Conversores;

public sealed class DictionaryApiTests
{
    public static TheoryData<IDictionaryApi> Apis =>
      [
          DictionaryApiExtensoes.ObterDictionaryApi(),
          TestsHelpers.ObterApi<IDictionaryApi>(s => s.AddDictionaryApi()),
       ];

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task ObterDictionaryWord_DeveRetornarItemAsync(IDictionaryApi api)
    {
        // Arrange
        const string word = "Hello";

        // Act
        var significado = await api.ObterSignificadoPorPalavraAsync(word);

        // Assert
        significado.IsSuccessStatusCode.Should().BeTrue();
        significado.Content.Should().NotBeNullOrEmpty();
        significado.Content![0].Word.Should().BeEquivalentTo(word);
    }
}
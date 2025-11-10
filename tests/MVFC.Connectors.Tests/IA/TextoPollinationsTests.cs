namespace MVFC.Connectors.Tests.IA;

public sealed class TextoPollinationsTests
{
    public static TheoryData<ITextoPollinationsApi> Apis =>
     [
          TextoPollinationsExtensoes.ObterTextoPollinationsApi(),
          TestsHelpers.ObterApi<ITextoPollinationsApi>(s => s.AddTextoPollinations()),
     ];

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task GerarTexto_DeveRetornarNaoVazioAsync(ITextoPollinationsApi api)
    {
        // Arrange
        const string prompt = "Quem é Darth Vader?";

        // Act
        var textoGerado = await api.GerarTextoAsync(prompt);

        // Assert
        textoGerado.IsSuccessful.Should().BeTrue();
        textoGerado.Content.Should().NotBeNull();
    }
}
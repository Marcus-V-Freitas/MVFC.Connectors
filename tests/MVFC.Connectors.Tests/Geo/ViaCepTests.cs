namespace MVFC.Connectors.Tests.Geo;

public sealed class ViaCepTests
{
    public static TheoryData<IViaCepApi> Apis =>
     [
          ViaCepApiExtensoes.ObterViaCepApi(),
          TestsHelpers.ObterApi<IViaCepApi>(s => s.AddViaCep()),
     ];

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task ObterInfosDoCepAsync_DeveRetornarItemAsync(IViaCepApi api)
    {
        // Arrange
        const string cep = "04514103";

        // Act
        var viaCepDados = await api.ObterDadosPorCepAsync(cep);

        // Assert
        viaCepDados.IsSuccessful.Should().BeTrue();
        viaCepDados.Content.Should().NotBeNull();
    }
}
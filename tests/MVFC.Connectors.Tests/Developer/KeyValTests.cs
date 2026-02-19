namespace MVFC.Connectors.Tests.Developer;

public sealed class KeyValTests
{
    public static TheoryData<IKeyValApi> Apis =>
    new()
    {
        { KeyValExtensoes.ObterKeyValApi() },
        { TestsHelpers.ObterApi<IKeyValApi>(s => s.AddKeyVal()) },
    };

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task ObterKeyVal_DeveRetornarItemAsync(IKeyValApi api)
    {
        // Arrange
        var chave = Guid.NewGuid().ToString();
        const string valor = "valor_teste";

        // Act
        var chaveGerada = await api.AdicionarChaveAsync(chave, valor);

        // Assert
        chaveGerada.IsSuccessful.Should().BeTrue();
        chaveGerada.Content.Should().NotBeNull();
        chaveGerada.Content!.Val.Should().Be(valor);

        // Act
        var chaveObtida = await api.ObterChaveAsync(chave);

        // Assert
        chaveObtida.IsSuccessful.Should().BeTrue();
        chaveObtida.Content.Should().NotBeNull();
        chaveObtida.Content!.Val.Should().Be(valor);
    }
}
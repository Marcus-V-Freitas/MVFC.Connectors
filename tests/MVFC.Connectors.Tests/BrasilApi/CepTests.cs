namespace MVFC.Connectors.Tests.BrasilApi;

public sealed class CepTests
{
    public static TheoryData<ICepBrasilApi> Apis =>
        [
            CepBrasilApiExtensoes.ObterCepBrasilApi(),
            TestsHelpers.ObterApi<ICepBrasilApi>(s => s.AddCepBrasilApi()),
        ];

    [Theory]
    [MemberData(nameof(Apis))]

    public async Task RecuperarCep_v1_DeveRetornarDadosCorretos(ICepBrasilApi api)
    {
        // Arrange
        const string cep = "01001000";
        const string version = "v1";

        // Act
        var resultado = await api.ObterCepPorNumeroAsync(cep, version);

        // Assert
        resultado.IsSuccessful.Should().BeTrue();
        resultado.Content.Should().NotBeNull();
        resultado.Content?.Cep.Should().Be(cep);
        resultado.Content?.State.Should().Be("SP");
        resultado.Content?.City.Should().Be("São Paulo");
        resultado.Content?.Neighborhood.Should().Be("Sé");
        resultado.Content?.Street.Should().Contain("Praça da Sé");
    }

    [Theory]
    [MemberData(nameof(Apis))]

    public async Task RecuperarCep_v2_DeveRetornarDadosCorretos(ICepBrasilApi api)
    {
        // Arrange
        const string cep = "01001000";
        const string version = "v2";

        // Act
        var resultado = await api.ObterCepPorNumeroAsync(cep, version);

        // Assert
        resultado.IsSuccessful.Should().BeTrue();
        resultado.Content.Should().NotBeNull();
        resultado.Content?.Cep.Should().Be(cep);
        resultado.Content?.State.Should().Be("SP");
        resultado.Content?.City.Should().Be("São Paulo");
        resultado.Content?.Neighborhood.Should().Be("Sé");
        resultado.Content?.Street.Should().Contain("Praça da Sé");
    }
}
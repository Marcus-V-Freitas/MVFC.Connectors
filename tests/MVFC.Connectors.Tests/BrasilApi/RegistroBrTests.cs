namespace MVFC.Connectors.Tests.BrasilApi;

public sealed class RegistroBrTests
{
    public static TheoryData<IRegistroBrApi> Apis =>
      [
          RegistroBrBrasilApiExtensoes.ObterRegistroBrBrasilApi(),
          TestsHelpers.ObterApi<IRegistroBrApi>(s => s.AddRegistroBrBrasilApi()),
       ];

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task RecuperarRegistroBrPorDominio_DeveRetornarItens(IRegistroBrApi api)
    {
        // Arrange
        const string dominio = "marcus";

        // Act
        var registro = await api.VerificarStatusDoDominioAsync(dominio);

        // Assert
        registro.IsSuccessful.Should().BeTrue();
        registro.Content.Should().NotBeNull();
        registro.Content?.Status.Should().Be("REGISTERED");
    }
}
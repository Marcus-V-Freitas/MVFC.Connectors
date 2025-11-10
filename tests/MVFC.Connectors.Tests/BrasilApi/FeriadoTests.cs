namespace MVFC.Connectors.Tests.BrasilApi;

public sealed class FeriadoTests
{
    public static TheoryData<IFeriadoBrasilApi> Apis =>
       [
           FeriadoBrasilApiExtensoes.ObterFeriadoBrasilApi(),
            TestsHelpers.ObterApi<IFeriadoBrasilApi>(s => s.AddFeriadoBrasilApi()),
       ];

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task RecuperarFeriadoPorAno_DeveRetornarItem(IFeriadoBrasilApi api)
    {
        // Arrange
        const int ano = 2025;

        // & Act
        var feriados = await api.ObterFeriadosPorAnoAsync(ano);

        // Assert
        feriados.IsSuccessful.Should().BeTrue();
        feriados.Content.Should().NotBeNull();
        feriados.Content.Should().Contain(f => f.Name == "Natal");
    }
}

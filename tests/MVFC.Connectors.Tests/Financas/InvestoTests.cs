namespace MVFC.Connectors.Tests.Financas;

public sealed class InvestoTests
{
    public static TheoryData<IInvestoApi> Apis =>
     [
          InvestoExtensoes.ObterInvestoApi(),
          TestsHelpers.ObterApi<IInvestoApi>(s => s.AddInvesto()),
     ];

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task ObterEtfPorNome_DeveRetornarItemAsync(IInvestoApi api)
    {
        // Arrange
        const string nome = "GPUS11";

        // Act
        var investoEtf = await api.ObterEtfPorNomeAsync(nome);

        // Assert
        investoEtf.IsSuccessful.Should().BeTrue();
        investoEtf.Content.Should().NotBeNull();
        investoEtf.Content!.Nome.Should().Be(nome);
    }
}
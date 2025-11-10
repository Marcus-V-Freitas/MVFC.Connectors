namespace MVFC.Connectors.Tests.Justica;

public sealed class DataJudTests
{
    public static TheoryData<IDataJudApi> Apis =>
     [
          DataJudExtensoes.ObterDataJudApi(),
          TestsHelpers.ObterApi<IDataJudApi>(s => s.AddDataJud()),
     ];

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task ObterDataJudProcesso_Console_DeveRetornarItemAsync(IDataJudApi api)
    {
        // Arrange
        const DataJudTribunal tribunal = DataJudTribunal.TRF1;
        const string numeroProcesso = "00008323520184013202";
        var request = DataJudProcessoRequest.CriarPorNumero(numeroProcesso);

        // Act
        var processoDataJud = await api.ObterProcessosPorNumeroAsync(tribunal, request);

        // Assert
        processoDataJud.IsSuccessful.Should().BeTrue();
        processoDataJud.Content.Should().NotBeNull();
        processoDataJud.Content!.Hits.Hits[0].Source.NumeroProcesso.Should().Be(numeroProcesso);
    }
}
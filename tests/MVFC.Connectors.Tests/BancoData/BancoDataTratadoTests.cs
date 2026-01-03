namespace MVFC.Connectors.Tests.BancoData;

public sealed class BancoDataTratadoTests
{
    public static TheoryData<IBancoDataTratadoApi> Apis =>
      [
          BancoDataTratadoExtensoes.ObterBancoTratadoApi(),
          TestsHelpers.ObterApi<IBancoDataTratadoApi>(s => s.AddBancoDataTratado()),
       ];

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task DadosTratados_DeveRetornarItemAsync(IBancoDataTratadoApi api)
    {
        // Arrange
        const string bankCode = "master";

        // Act
        var dadosTratados = await api.ObterDadosTratadosAsync(bankCode);

        // Assert
        dadosTratados.IsSuccessStatusCode.Should().BeTrue();
        dadosTratados.Content.Should().NotBeNull();
        dadosTratados.Content!.Codigo.Should().BeEquivalentTo(bankCode);
    }
}
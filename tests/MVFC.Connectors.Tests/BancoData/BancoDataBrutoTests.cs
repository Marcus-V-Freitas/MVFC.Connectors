namespace MVFC.Connectors.Tests.BancoData;

public sealed class BancoDataBrutoTests
{
    public static TheoryData<IBancoDataBrutoApi> Apis =>
    new()
    {
        BancoDataBrutoExtensoes.ObterBancoDataBrutoApi(),
        TestsHelpers.ObterApi<IBancoDataBrutoApi>(s => s.AddBancoDataBruto()),
    };

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task DadosBrutos_DeveRetornarItemAsync(IBancoDataBrutoApi api)
    {
        // Arrange
        const string bankCode = "icbc-do-brasil-bm-sa";

        // Act
        var dadosBrutos = await api.ObterDadosBrutosAsync(bankCode);

        // Assert
        dadosBrutos.IsSuccessStatusCode.Should().BeTrue();
        dadosBrutos.Content.Should().NotBeNull();
        dadosBrutos.Content!.Codigo.Should().BeEquivalentTo(bankCode);
    }
}
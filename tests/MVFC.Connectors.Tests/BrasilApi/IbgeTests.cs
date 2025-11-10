namespace MVFC.Connectors.Tests.BrasilApi;

public sealed class IbgeTests
{
    private readonly IReadOnlyList<IbgeProvedor> _provedores =
        [
            IbgeProvedor.DadosAbertos,
            IbgeProvedor.Gov,
            IbgeProvedor.Wikipedia,
        ];

    public static TheoryData<IIbgeBrasilApi> Apis =>
       [
           IbgeBrasilApiExtensoes.ObterIbgeBrasilApi(),
           TestsHelpers.ObterApi<IIbgeBrasilApi>(s => s.AddIbgeBrasilApi()),
       ];

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task RecuperarMunicipiosUfs_DeveRetornarItens(IIbgeBrasilApi api)
    {
        // Arrange
        const IbgeSiglaUf siglaUf = IbgeSiglaUf.SP;

        //Act
        var municipios = await api.ObterMunicipiosPorUfAsync(siglaUf, _provedores);

        // Assert
        municipios.IsSuccessful.Should().BeTrue();
        municipios.Content.Should().NotBeNullOrEmpty();

        // Arrange & Act
        var ufs = await api.ObterEstadosAsync();

        // Assert
        ufs.IsSuccessful.Should().BeTrue();
        ufs.Content.Should().NotBeNullOrEmpty();
    }

    [Theory]
    [MemberData(nameof(Apis))]
    public async Task RecuperarUfPorCodigo_DeveRetornarItens(IIbgeBrasilApi api)
    {
        // Arrange &
        const int codigo = 35;

        // Act
        var uf = await api.ObterEstadoPorCodigoAsync(codigo);

        // Assert
        uf.IsSuccessful.Should().BeTrue();
        uf.Content.Should().NotBeNull();
    }
}
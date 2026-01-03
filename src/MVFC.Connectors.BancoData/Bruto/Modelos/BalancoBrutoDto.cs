namespace MVFC.Connectors.BancoData.Bruto.Modelos;

public sealed record BalancoBrutoDto(
    string DataApuracao,
    string PatrimonioLiquido,
    string PatrimonioReferencia);
namespace MVFC.Connectors.BancoData.Tratado.Modelos;

public sealed record BalancoTratadoDto(
    DateTime DataApuracao,
    int Ano,
    int Mes,
    decimal PatrimonioLiquido,
    decimal PatrimonioReferencia,
    decimal Diferenca);
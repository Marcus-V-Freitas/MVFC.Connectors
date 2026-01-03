namespace MVFC.Connectors.BancoData.Tratado.Modelos;

public sealed record IndicadoresTratadoDto(
    DateTime DataReferencia,
    decimal IndiceBasileia,
    decimal IndiceImobilizacao,
    SituacaoBasileia SituacaoBasileia,
    SituacaoImobilizacao SituacaoImobilizacao);
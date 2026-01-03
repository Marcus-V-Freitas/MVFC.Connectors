namespace MVFC.Connectors.BancoData.Tratado.Modelos;

public sealed record RedeAtendimentoTratadoDto(
    DateTime DataReferencia,
    int NumeroAgencias,
    int? PontosAtendimento,
    int TotalPontosPresenciais);
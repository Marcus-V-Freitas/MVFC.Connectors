namespace MVFC.Connectors.BancoData.Tratado.Modelos;

public sealed record RedeAtendimentoTratadoDto(
    DateTimeOffset DataReferencia,
    int NumeroAgencias,
    int? PontosAtendimento,
    int TotalPontosPresenciais);

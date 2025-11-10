namespace MVFC.Connectors.Justica.DataJud.Modelos;

public sealed record DataJudProcessoDto(
    [property: JsonPropertyName("classe")] DataJudClasseDto Classe,
    [property: JsonPropertyName("numeroProcesso")] string NumeroProcesso,
    [property: JsonPropertyName("sistema")] DataJudSistemaDto Sistema,
    [property: JsonPropertyName("formato")] DataJudFormatoDto Formato,
    [property: JsonPropertyName("tribunal")] string Tribunal,
    [property: JsonPropertyName("dataHoraUltimaAtualizacao")] DateTime DataHoraUltimaAtualizacao,
    [property: JsonPropertyName("grau")] string Grau,
    [property: JsonPropertyName("@timestamp")] string Timestamp,
    [property: JsonPropertyName("dataAjuizamento")] string DataAjuizamento,
    [property: JsonPropertyName("movimentos")] IReadOnlyList<DataJudMovimento> Movimentos,
    [property: JsonPropertyName("id")] string Id,
    [property: JsonPropertyName("nivelSigilo")] int NivelSigilo,
    [property: JsonPropertyName("orgaoJulgador")] DataJudOrgaoJulgadorDto OrgaoJulgador,
    [property: JsonPropertyName("assuntos")] IReadOnlyList<DataJudAssuntoDto> Assuntos);

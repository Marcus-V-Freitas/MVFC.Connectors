namespace MVFC.Connectors.BrasilApi.CNPJ.Modelos.Dtos;

public sealed record QsaDto(
    [property: JsonPropertyName("pais")] string? Pais,
    [property: JsonPropertyName("nome_socio")] string NomeSocio,
    [property: JsonPropertyName("codigo_pais")] int? CodigoPais,
    [property: JsonPropertyName("faixa_etaria")] string FaixaEtaria,
    [property: JsonPropertyName("cnpj_cpf_do_socio")] string CnpjCpfDoSocio,
    [property: JsonPropertyName("qualificacao_socio")] string QualificacaoSocio,
    [property: JsonPropertyName("codigo_faixa_etaria")] int CodigoFaixaEtaria,
    [property: JsonPropertyName("data_entrada_sociedade")] DateTime DataEntradaSociedade,
    [property: JsonPropertyName("identificador_de_socio")] IdentificadorSocio IdentificadorDeSocio,
    [property: JsonPropertyName("cpf_representante_legal")] string CpfRepresentanteLegal,
    [property: JsonPropertyName("nome_representante_legal")] string NomeRepresentanteLegal,
    [property: JsonPropertyName("codigo_qualificacao_socio")] int CodigoQualificacaoSocio,
    [property: JsonPropertyName("qualificacao_representante_legal")] string QualificacaoRepresentanteLegal,
    [property: JsonPropertyName("codigo_qualificacao_representante_legal")] int CodigoQualificacaoRepresentanteLegal);
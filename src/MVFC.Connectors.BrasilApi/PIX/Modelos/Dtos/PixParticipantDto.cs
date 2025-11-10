namespace MVFC.Connectors.BrasilApi.PIX.Modelos.Dtos;

public sealed record PixParticipantDto(
    [property: JsonPropertyName("ispb")] string Ispb,
    [property: JsonPropertyName("nome")] string Nome,
    [property: JsonPropertyName("nome_reduzido")] string NomeReduzido,
    [property: JsonPropertyName("modalidade_participacao")] string ModalidadeParticipacao,
    [property: JsonPropertyName("tipo_participacao")] string TipoParticipacao,
    [property: JsonPropertyName("inicio_operacao")] DateTime InicioOperacao);
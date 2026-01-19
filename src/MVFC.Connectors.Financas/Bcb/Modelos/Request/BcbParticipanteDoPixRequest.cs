namespace MVFC.Connectors.Financas.Bcb.Modelos.Request;

public sealed record BcbParticipanteDoPixRequest(
        [property: JsonPropertyName("segmento")] BcbSegmentoDto? Segmento = null,
        [property: JsonPropertyName("nome")] string Nome = "",
        [property: JsonPropertyName("cnpj")] string Cnpj = "",
        [property: JsonPropertyName("tipoParticipacao")] TipoParticipacao? TipoParticipacao = null,
        [property: JsonPropertyName("modalidadeParticipacao")] ModalidadeParticipacao? ModalidadeParticipacao = null,
        [property: JsonPropertyName("tipoParticipacaoSPI")] TipoParticipacaoSPI? TipoParticipacaoSPI = null,
        [property: JsonPropertyName("servicoIniciacaoViaOpenFinance")] bool ServicoIniciacaoViaOpenFinance = false,
        [property: JsonPropertyName("facilitadorServicoSaque")] bool FacilitadorServicoSaque = false,
        [property: JsonPropertyName("ofertaRecebimentoPixAutomatico")] bool OfertaRecebimentoPixAutomatico = false,
        [property: JsonPropertyName("apiPix")] bool ApiPix = false,
        [property: JsonPropertyName("ofertaContasPF")] bool OfertaContasPF = false,
        [property: JsonPropertyName("ofertaContasPJ")] bool OfertaContasPJ = false,
        [property: JsonPropertyName("pixCobrancaPagamentosVencimento")] bool PixCobrancaPagamentosVencimento = false,
        [property: JsonPropertyName("pixCobrancaPagamentosImediatosDinamico")] bool PixCobrancaPagamentosImediatosDinamico = false,
        [property: JsonPropertyName("pixCobrancaPagamentosImediatosEstatico")] bool PixCobrancaPagamentosImediatosEstatico = false,
        [property: JsonPropertyName("ofertaPixSaquePixTroco")] bool OfertaPixSaquePixTroco = false,
        int TamanhoPagina = 20,
        int NumeroPagina = 0) :
            BbcRequest(TamanhoPagina, NumeroPagina);
namespace MVFC.Connectors.Sicoob.Enums.CobrancaBancaria;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum EspecieDocumento
{
    CH,   // Cheque
    DM,   // Duplicata Mercantil
    DMI,  // Duplicata Mercantil Indicação
    DS,   // Duplicata de Serviço
    DSI,  // Duplicata Serviço Indicação
    DR,   // Duplicata Rural
    LC,   // Letra de Câmbio
    NCC,  // Nota de Crédito Comercial
    NCE,  // Nota de Crédito Exportação
    NCI,  // Nota de Crédito Industrial
    NCR,  // Nota de Crédito Rural
    NP,   // Nota Promissória
    NPR,  // Nota Promissória Rural
    TM,   // Triplicata Mercantil
    TS,   // Triplicata de Serviço
    NS,   // Nota de Seguro
    RC,   // Recibo
    FAT,  // Fatura
    ND,   // Nota de Débito
    AP,   // Apólice de Seguro
    ME,   // Mensalidade Escolar
    PC,   // Pagamento de Consórcio
    NF,   // Nota Fiscal
    DD,   // Documento de Dívida
    CC,   // Cartão de Crédito
    BDP,  // Boleto Proposta
    OU,   // Outros
}
namespace MVFC.Connectors.BancoData.Tratado.Modelos;

public sealed record InfoBasicaTratadoDto(
    string Matriz,
    string MatrizCidade,
    string MatrizEstado,
    string SiteOficial,
    string TipoConsolidacao,
    string NomeFantasia,
    string RazaoSocial,
    string CNPJFormatado,
    string CNPJNumerico,
    DateTime DataAbertura,
    int AnosOperacao,
    string ControleAcionario,
    TipoControle TipoControle,
    string TipoInstituicao);
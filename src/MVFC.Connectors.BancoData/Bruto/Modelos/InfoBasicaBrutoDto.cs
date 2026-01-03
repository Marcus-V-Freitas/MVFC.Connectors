namespace MVFC.Connectors.BancoData.Bruto.Modelos;

public sealed record InfoBasicaBrutoDto(
        string Matriz,
        string SiteOficial,
        string TipoConsolidacao,
        string NomeFantasia,
        string RazaoSocial,
        string CNPJ,
        string DataAbertura,
        string ControleAcionario,
        string TipoInstituicao);
namespace MVFC.Connectors.BancoData.Enums;

public enum SituacaoImobilizacao
{
    /// <summary>
    /// Imobilização adequada (≤ 50%)
    /// </summary>
    Adequado,

    /// <summary>
    /// Imobilização em atenção (50% - 60%)
    /// Acima do limite mas ainda controlável
    /// </summary>
    Atencao,

    /// <summary>
    /// Imobilização crítica (> 60%)
    /// Muito acima do limite regulatório
    /// </summary>
    Critico
}
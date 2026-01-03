namespace MVFC.Connectors.BancoData.Bruto.Modelos;

public sealed record ResultadoAnualBrutoDto(
        string Ano,
        string Tipo,
        string Valor);
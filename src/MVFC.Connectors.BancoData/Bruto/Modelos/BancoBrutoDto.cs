namespace MVFC.Connectors.BancoData.Bruto.Modelos;

public sealed record BancoBrutoDto(
   string Nome,
   string Codigo,
   InfoBasicaBrutoDto InfoBasica,
   RedeAtendimentoBrutoDto RedeAtendimento,
   List<ResultadoAnualBrutoDto> ResultadosAnuais,
   IndicadoresBrutoDto Indicadores,
   DemonstrativoBrutoDto DRE,
   BalancoBrutoDto Balanco);
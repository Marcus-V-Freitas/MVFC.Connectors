namespace MVFC.Connectors.BancoData.Tratado.Modelos;

public sealed record BancoTratadoDto(
    string Nome,
    string Codigo,
    InfoBasicaTratadoDto InfoBasica,
    RedeAtendimentoTratadoDto RedeAtendimento,
    List<ResultadoAnualTratadoDto> ResultadosAnuais,
    IndicadoresTratadoDto Indicadores,
    DemonstrativoTratadoDto DRE,
    BalancoTratadoDto Balanco,
    BancoBrutoDto DadosBruto);
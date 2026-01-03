namespace MVFC.Connectors.BancoData.Tratado.Transform;

internal sealed class BancoDataTransformer : IBancoDataTransform
{
    public BancoTratadoDto Transformar(BancoBrutoDto dadosBrutos) =>
        new(
            dadosBrutos.Nome,
            dadosBrutos.Codigo,
            TransformInfoBasica(dadosBrutos.InfoBasica),
            TransformRedeAtendimento(dadosBrutos.RedeAtendimento),
            TransformResultadosAnuais(dadosBrutos.ResultadosAnuais),
            TransformIndicadores(dadosBrutos.Indicadores),
            TransformDRE(dadosBrutos.DRE),
            TransformBalanco(dadosBrutos.Balanco),
            dadosBrutos);

    private static InfoBasicaTratadoDto TransformInfoBasica(InfoBasicaBrutoDto dadosBrutos)
    {
        var (cidade, estado) = HelpersExtensoes.ExtrairMatriz(dadosBrutos.Matriz);
        var cnpjNumerico = HelpersExtensoes.ExtrairCnpjNumerico(dadosBrutos.CNPJ);
        var dataAbertura = HelpersExtensoes.ExtrairDataDoTexto(dadosBrutos.DataAbertura);
        var anosOperacao = HelpersExtensoes.CalcularAnosDeOperacao(dataAbertura);
        var tipoControle = HelpersExtensoes.ClassificarControleAcionario(dadosBrutos.ControleAcionario);

        return new InfoBasicaTratadoDto(
            dadosBrutos.Matriz,
            cidade,
            estado,
            dadosBrutos.SiteOficial,
            dadosBrutos.TipoConsolidacao,
            dadosBrutos.NomeFantasia,
            dadosBrutos.RazaoSocial,
            dadosBrutos.CNPJ,
            cnpjNumerico,
            dataAbertura,
            anosOperacao,
            dadosBrutos.ControleAcionario,
            tipoControle,
            dadosBrutos.TipoInstituicao);
    }

    private static RedeAtendimentoTratadoDto TransformRedeAtendimento(RedeAtendimentoBrutoDto dadosBrutos)
    {
        var data = HelpersExtensoes.ExtrairMesDoAno(dadosBrutos.DataReferencia);
        var agencias = HelpersExtensoes.ExtrairValorInteiro(dadosBrutos.NumeroAgencias);
        var pontos = dadosBrutos.PontosAtendimento == "-" ? (int?)null : HelpersExtensoes.ExtrairValorInteiro(dadosBrutos.PontosAtendimento);
        var total = agencias + (pontos ?? 0);

        return new RedeAtendimentoTratadoDto(
            data,
            agencias,
            pontos,
            total);
    }

    private static List<ResultadoAnualTratadoDto> TransformResultadosAnuais(List<ResultadoAnualBrutoDto> dadosBrutos) =>
        [.. dadosBrutos.Select(dadoBruto =>
        {
            var (ano, parcial) = HelpersExtensoes.ExtrairAno(dadoBruto.Ano);
            var tipoResultado = dadoBruto.Tipo.Contains("Lucro", StringComparison.OrdinalIgnoreCase)
                ? TipoResultado.Lucro
                : TipoResultado.Prejuizo;
            var valor = HelpersExtensoes.ExtrairValorMonetarioAbsoluto(dadoBruto.Valor);

            return new ResultadoAnualTratadoDto(
                ano,
                parcial,
                tipoResultado,
                valor);
        })];

    private static IndicadoresTratadoDto TransformIndicadores(IndicadoresBrutoDto dadosBrutos)
    {
        var data = HelpersExtensoes.ExtrairMesDoAno(dadosBrutos.Data);
        var basileia = HelpersExtensoes.ExtrairPercentual(dadosBrutos.IndiceBasileia);
        var imobilizacao = HelpersExtensoes.ExtrairPercentual(dadosBrutos.IndiceImobilizacao);
        var situacaoBasileia = HelpersExtensoes.ClassificarSituacaoBasileia(basileia);
        var situacaoImobilizacao = HelpersExtensoes.ClassificarSituacaoImobilizacao(imobilizacao);

        return new IndicadoresTratadoDto(
            data,
            basileia,
            imobilizacao,
            situacaoBasileia,
            situacaoImobilizacao);
    }

    private static DemonstrativoTratadoDto TransformDRE(DemonstrativoBrutoDto dadosBrutos)
    {
        var trimestre = HelpersExtensoes.ExtrairTrimestre(dadosBrutos.Trimestre);
        var (ano, numeroTrimestre) = HelpersExtensoes.ExtractTrimestreInfo(dadosBrutos.Trimestre);
        var lucro = HelpersExtensoes.ExtrairValorMonetario(dadosBrutos.LucroLiquido);
        var resultado = HelpersExtensoes.ExtrairValorMonetario(dadosBrutos.ResultadoOperacional);
        var margem = HelpersExtensoes.CalcularPercentual(resultado, lucro);

        return new DemonstrativoTratadoDto(
            trimestre,
            ano,
            numeroTrimestre,
            lucro,
            resultado,
            margem);
    }

    private static BalancoTratadoDto TransformBalanco(BalancoBrutoDto dadosBrutos)
    {
        var data = HelpersExtensoes.ExtrairMesDoAno(dadosBrutos.DataApuracao);
        var pl = HelpersExtensoes.ExtrairValorMonetario(dadosBrutos.PatrimonioLiquido);
        var pr = HelpersExtensoes.ExtrairValorMonetario(dadosBrutos.PatrimonioReferencia);
        var diferenca = pr - pl;

        return new BalancoTratadoDto(
            DataApuracao:
            data,
            data.Year,
            data.Month,
            pl,
            pr,
            diferenca);
    }
}
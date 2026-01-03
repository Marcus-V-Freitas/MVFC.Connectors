namespace MVFC.Connectors.BancoData.Tratado.Transform;

public interface IBancoDataTransform
{
    BancoTratadoDto Transformar(BancoBrutoDto dadosBrutos);
}
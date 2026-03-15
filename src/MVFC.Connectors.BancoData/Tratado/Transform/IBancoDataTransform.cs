namespace MVFC.Connectors.BancoData.Tratado.Transform;

public interface IBancoDataTransform
{
    public BancoTratadoDto Transformar(BancoBrutoDto dadosBrutos);
}

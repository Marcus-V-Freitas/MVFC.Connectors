namespace MVFC.Connectors.BancoData.Tratado.Modelos;

public sealed record DemonstrativoTratadoDto(
    DateTime Trimestre,
    int Ano,
    int NumeroTrimestre,
    decimal LucroLiquido,
    decimal ResultadoOperacional,
    decimal MargemOperacional);
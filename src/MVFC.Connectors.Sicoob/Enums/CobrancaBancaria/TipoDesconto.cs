namespace MVFC.Connectors.Sicoob.Enums.CobrancaBancaria;

[JsonConverter(typeof(SafeEnumConverter<TipoDesconto>))]
public enum TipoDesconto
{
    SemDesconto = 0,
    ValorFixoAteData = 1,
    PercentualAteData = 2,
    ValorAntecipacaoDiaCorrido = 3,
    ValorAntecipacaoDiaUtil = 4,
    PercentualAntecipacaoDiaCorrido = 5,
    PercentualAntecipacaoDiaUtil = 6,
}
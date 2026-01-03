namespace MVFC.Connectors.BancoData.Tratado.Modelos;

public sealed record ResultadoAnualTratadoDto(
   int Ano,
   bool AnoParcial,
   TipoResultado TipoResultado,
   decimal ValorAbsoluto);
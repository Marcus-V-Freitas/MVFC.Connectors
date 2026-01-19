namespace MVFC.Connectors.Financas.Bcb.Modelos.Enums;

public enum ModalidadeParticipacao
{
    [EnumMember(Value = "Provedor de conta transacional")]
    ProvedorDeContaTransacional,
    [EnumMember(Value = "Ente governamental")]
    EnteGovernamental,
    [EnumMember(Value = "Liquidante especial")]
    LiquidanteEspecial,
    [EnumMember(Value = "Iniciador")]
    Iniciador,
}
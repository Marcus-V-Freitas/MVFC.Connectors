namespace MVFC.Connectors.BrasilApi.PIX;

public interface IPixParticipantesBrasilApi : IConnectorApi
{
    [Get("/pix/v1/participants")]
    Task<ApiResponse<IReadOnlyList<PixParticipanteDto>>> ObterParticipantesPixAsync();
}
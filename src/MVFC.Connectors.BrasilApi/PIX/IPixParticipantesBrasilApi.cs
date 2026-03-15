namespace MVFC.Connectors.BrasilApi.PIX;

public interface IPixParticipantesBrasilApi : IConnectorApi
{
    [Get("/pix/v1/participants")]
    public Task<ApiResponse<IReadOnlyList<PixParticipanteDto>>> ObterParticipantesPixAsync();
}

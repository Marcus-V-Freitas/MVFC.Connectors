namespace MVFC.Connectors.BrasilApi.PIX;

public interface IPixParticipantBrasilApi : IConnectorApi
{
    [Get("/pix/v1/participants")]
    Task<ApiResponse<IReadOnlyList<PixParticipantDto>>> GetPixParticipantsAsync();
}
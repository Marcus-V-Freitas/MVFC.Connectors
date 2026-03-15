namespace MVFC.Connectors.BrasilApi.RegistroBR;

public interface IRegistroBrApi : IConnectorApi
{
    [Get("/registrobr/v1/{dominio}")]
    public Task<ApiResponse<RegistroBrDto>> VerificarStatusDoDominioAsync(string dominio);
}

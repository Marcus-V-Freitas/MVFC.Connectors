namespace MVFC.Connectors.Developer.DisifyEmail;

public interface IDisifyEmailApi : IConnectorApi
{
    [Get("/email/{email}")]
    [QueryUriFormat(UriFormat.Unescaped)]
    Task<ApiResponse<DisifyEmailDto>> VerificarValidadeDoEmailAsync(string email);
}

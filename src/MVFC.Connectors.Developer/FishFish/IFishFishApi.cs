namespace MVFC.Connectors.Developer.FishFish;

public interface IFishFishApi : IConnectorApi
{
    [Get("/domains")]
    Task<ApiResponse<IReadOnlyList<string>>> ObterPhishingAsync();
}
namespace MVFC.Connectors.Developer.FishFish;

public interface IFishFishApi : IConnectorApi
{
    [Get("/domains")]
    public Task<ApiResponse<IReadOnlyList<string>>> ObterPhishingAsync();
}

namespace MVFC.Connectors.Financas.Reddit.Modelos.Dtos;

public sealed record RedditStockDto(
    [property: JsonPropertyName("ticker")] string Ticker,
    [property: JsonPropertyName("sentiment")] string Sentiment,
    [property: JsonPropertyName("sentiment_score")] double SentimentScore,
    [property: JsonPropertyName("no_of_comments")] int NoOfComments);
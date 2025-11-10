namespace MVFC.Connectors.Commons.Extensoes;

internal static partial class ExtensoesLog
{
    [LoggerMessage(EventId = 1, Level = LogLevel.Debug, Message = "[LOG] Request: {Method} {Uri}")]
    public static partial void LogRequest(this ILogger logger, string method, Uri? uri);

    [LoggerMessage(EventId = 2, Level = LogLevel.Information, Message = "[LOG] Response: {StatusCode}")]
    public static partial void LogResponse(this ILogger logger, HttpStatusCode statusCode);
}
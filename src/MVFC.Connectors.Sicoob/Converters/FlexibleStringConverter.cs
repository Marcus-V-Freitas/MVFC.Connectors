namespace MVFC.Connectors.Sicoob.Converters;

internal sealed class FlexibleStringConverter : JsonConverter<string>
{
    public override string? Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return reader.TokenType switch
        {
            JsonTokenType.String => reader.GetString(),
            JsonTokenType.Number when reader.TryGetInt64(out var longValue) => longValue.ToString(),
            JsonTokenType.Number when reader.TryGetDouble(out var doubleValue) => doubleValue.ToString("F0"),
            JsonTokenType.Null => null,
            _ => throw new JsonException($"Não é possível converter {reader.TokenType} para string")
        };
    }

    public override void Write(Utf8JsonWriter writer, string? value, JsonSerializerOptions options)
    {
        if (value == null)
            writer.WriteNullValue();
        else
            writer.WriteStringValue(value);
    }
}
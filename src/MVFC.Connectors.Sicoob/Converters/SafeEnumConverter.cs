namespace MVFC.Connectors.Sicoob.Converters;

public sealed class SafeEnumConverter<TEnum> : JsonConverter<TEnum>
    where TEnum : struct, Enum
{
    public override TEnum Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
    {
        return reader.TokenType switch
        {
            JsonTokenType.Number when reader.TryGetInt32(out var numValue)
                => Enum.IsDefined(typeof(TEnum), numValue)
                    ? (TEnum)Enum.ToObject(typeof(TEnum), numValue)
                    : default,

            JsonTokenType.String when !string.IsNullOrEmpty(reader.GetString())
                => Enum.TryParse<TEnum>(reader.GetString(), true, out var enumValue)
                    ? enumValue
                    : default,

            _ => default
        };
    }

    public override void Write(Utf8JsonWriter writer, TEnum value, JsonSerializerOptions options)
        => writer.WriteNumberValue(Convert.ToInt32(value));
}
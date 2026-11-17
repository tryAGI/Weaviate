#nullable enable

namespace Weaviate.JsonConverters
{
    /// <inheritdoc />
    public sealed class UsageLimitExceededResponseErrorCodeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Weaviate.UsageLimitExceededResponseErrorCode?>
    {
        /// <inheritdoc />
        public override global::Weaviate.UsageLimitExceededResponseErrorCode? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Weaviate.UsageLimitExceededResponseErrorCodeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Weaviate.UsageLimitExceededResponseErrorCode)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Weaviate.UsageLimitExceededResponseErrorCode?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Weaviate.UsageLimitExceededResponseErrorCode? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Weaviate.UsageLimitExceededResponseErrorCodeExtensions.ToValueString(value.Value));
            }
        }
    }
}

#nullable enable

namespace Weaviate.JsonConverters
{
    /// <inheritdoc />
    public sealed class BatchReferenceResponseVariant2ResultStatusJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Weaviate.BatchReferenceResponseVariant2ResultStatus>
    {
        /// <inheritdoc />
        public override global::Weaviate.BatchReferenceResponseVariant2ResultStatus Read(
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
                        return global::Weaviate.BatchReferenceResponseVariant2ResultStatusExtensions.ToEnum(stringValue) ?? default;
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Weaviate.BatchReferenceResponseVariant2ResultStatus)numValue;
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Weaviate.BatchReferenceResponseVariant2ResultStatus value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Weaviate.BatchReferenceResponseVariant2ResultStatusExtensions.ToValueString(value));
        }
    }
}

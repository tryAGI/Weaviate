#nullable enable

namespace Weaviate.JsonConverters
{
    /// <inheritdoc />
    public sealed class SearchReferenceSelectorReturnMetadataItemJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Weaviate.SearchReferenceSelectorReturnMetadataItem>
    {
        /// <inheritdoc />
        public override global::Weaviate.SearchReferenceSelectorReturnMetadataItem Read(
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
                        return global::Weaviate.SearchReferenceSelectorReturnMetadataItemExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Weaviate.SearchReferenceSelectorReturnMetadataItem)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Weaviate.SearchReferenceSelectorReturnMetadataItem);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Weaviate.SearchReferenceSelectorReturnMetadataItem value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Weaviate.SearchReferenceSelectorReturnMetadataItemExtensions.ToValueString(value));
        }
    }
}

#nullable enable

namespace Weaviate.JsonConverters
{
    /// <inheritdoc />
    public sealed class SchemaObjectsIndexRebuildIndexNameJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Weaviate.SchemaObjectsIndexRebuildIndexName>
    {
        /// <inheritdoc />
        public override global::Weaviate.SchemaObjectsIndexRebuildIndexName Read(
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
                        return global::Weaviate.SchemaObjectsIndexRebuildIndexNameExtensions.ToEnum(stringValue) ?? default;
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Weaviate.SchemaObjectsIndexRebuildIndexName)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Weaviate.SchemaObjectsIndexRebuildIndexName);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Weaviate.SchemaObjectsIndexRebuildIndexName value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            writer.WriteStringValue(global::Weaviate.SchemaObjectsIndexRebuildIndexNameExtensions.ToValueString(value));
        }
    }
}

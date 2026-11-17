#nullable enable

namespace Weaviate.JsonConverters
{
    /// <inheritdoc />
    public sealed class GetRolesForGroupGroupTypeNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Weaviate.GetRolesForGroupGroupType?>
    {
        /// <inheritdoc />
        public override global::Weaviate.GetRolesForGroupGroupType? Read(
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
                        return global::Weaviate.GetRolesForGroupGroupTypeExtensions.ToEnum(stringValue);
                    }

                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Weaviate.GetRolesForGroupGroupType)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Weaviate.GetRolesForGroupGroupType?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Weaviate.GetRolesForGroupGroupType? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Weaviate.GetRolesForGroupGroupTypeExtensions.ToValueString(value.Value));
            }
        }
    }
}

#nullable enable
#pragma warning disable CS0618 // Type or member is obsolete

namespace Weaviate.JsonConverters
{
    /// <inheritdoc />
    public class SearchNearVectorRequestJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Weaviate.SearchNearVectorRequest>
    {
        /// <inheritdoc />
        public override global::Weaviate.SearchNearVectorRequest Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");

            using var __jsonDocument = global::System.Text.Json.JsonDocument.ParseValue(ref reader);
            var __rawJson = __jsonDocument.RootElement.GetRawText();

            global::Weaviate.SearchCommon? common = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Weaviate.SearchCommon), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Weaviate.SearchCommon> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Weaviate.SearchCommon).Name}");
                common = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }
            catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
            {
                // Legacy enum converters signal an incompatible JSON token with this exception.
            }

            global::Weaviate.SearchNearVectorRequestVariant2? searchNearVectorRequestVariant2 = default;
            try
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Weaviate.SearchNearVectorRequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Weaviate.SearchNearVectorRequestVariant2> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Weaviate.SearchNearVectorRequestVariant2).Name}");
                searchNearVectorRequestVariant2 = global::System.Text.Json.JsonSerializer.Deserialize(__rawJson, typeInfo);
            }
            catch (global::System.Text.Json.JsonException)
            {
            }
            catch (global::System.InvalidOperationException)
            {
            }
            catch (global::System.ArgumentOutOfRangeException __enumTokenException) when (__enumTokenException.ParamName == "reader")
            {
                // Legacy enum converters signal an incompatible JSON token with this exception.
            }
            var __value = new global::Weaviate.SearchNearVectorRequest(
                common,

                searchNearVectorRequestVariant2
                );

            return __value;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Weaviate.SearchNearVectorRequest value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            options = options ?? throw new global::System.ArgumentNullException(nameof(options));
            var typeInfoResolver = options.TypeInfoResolver ?? throw new global::System.InvalidOperationException("TypeInfoResolver is not set.");


            writer.WriteStartObject();
            var __writtenPropertyNames = new global::System.Collections.Generic.HashSet<string>(global::System.StringComparer.Ordinal);
            if (value.IsCommon)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Weaviate.SearchCommon), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Weaviate.SearchCommon?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Weaviate.SearchCommon).Name}");
                var __element0 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.PickCommon(), typeInfo);
                if (__element0.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element0.EnumerateObject())
                {
                    if (__writtenPropertyNames.Add(__property.Name))
                    {
                        __property.WriteTo(writer);
                    }
                }
            }
            if (value.IsSearchNearVectorRequestVariant2)
            {
                var typeInfo = typeInfoResolver.GetTypeInfo(typeof(global::Weaviate.SearchNearVectorRequestVariant2), options) as global::System.Text.Json.Serialization.Metadata.JsonTypeInfo<global::Weaviate.SearchNearVectorRequestVariant2?> ??
                               throw new global::System.InvalidOperationException($"Cannot get type info for {typeof(global::Weaviate.SearchNearVectorRequestVariant2).Name}");
                var __element1 = global::System.Text.Json.JsonSerializer.SerializeToElement(value.PickSearchNearVectorRequestVariant2(), typeInfo);
                if (__element1.ValueKind != global::System.Text.Json.JsonValueKind.Object)
                {
                    throw new global::System.Text.Json.JsonException("AllOf values must serialize as JSON objects.");
                }

                foreach (var __property in __element1.EnumerateObject())
                {
                    if (__writtenPropertyNames.Add(__property.Name))
                    {
                        __property.WriteTo(writer);
                    }
                }
            }
            writer.WriteEndObject();
        }
    }
}
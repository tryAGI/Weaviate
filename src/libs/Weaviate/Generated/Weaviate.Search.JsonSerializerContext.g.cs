
#nullable enable

namespace Weaviate
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
    )]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.ErrorResponseErrorItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ErrorResponseErrorItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Weaviate.JsonObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.JsonObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.GeoCoordinates))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.WhereFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.WhereFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.WhereFilterOperator), TypeInfoPropertyName = "WhereFilterOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<bool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.WhereFilterGeoRange))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.WhereFilterGeoRangeDistance))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SearchBm25Request), TypeInfoPropertyName = "SearchBm25Request2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SearchCommon))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SearchBm25RequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.SearchReferenceSelector>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SearchReferenceSelector))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.SearchCommonReturnMetadataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SearchCommonReturnMetadataItem), TypeInfoPropertyName = "SearchCommonReturnMetadataItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SearchCommonConsistencyLevel), TypeInfoPropertyName = "SearchCommonConsistencyLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SearchRerank))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.SearchReferenceSelectorReturnMetadataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SearchReferenceSelectorReturnMetadataItem), TypeInfoPropertyName = "SearchReferenceSelectorReturnMetadataItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SearchHybridRequest), TypeInfoPropertyName = "SearchHybridRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SearchHybridRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SearchHybridRequestVariant2FusionType), TypeInfoPropertyName = "SearchHybridRequestVariant2FusionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SearchNearObjectRequest), TypeInfoPropertyName = "SearchNearObjectRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SearchNearObjectRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SearchNearTextRequest), TypeInfoPropertyName = "SearchNearTextRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SearchNearTextRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SearchNearVectorRequest), TypeInfoPropertyName = "SearchNearVectorRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SearchNearVectorRequestVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SearchResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.SearchResultObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SearchResultObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SearchResultMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SearchResultReferenceMetadata))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SearchResultReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Weaviate.SearchResultReference>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.SearchResultReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.WhereFilterOperator?), TypeInfoPropertyName = "NullableWhereFilterOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SearchBm25Request?), TypeInfoPropertyName = "NullableSearchBm25Request2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SearchCommonReturnMetadataItem?), TypeInfoPropertyName = "NullableSearchCommonReturnMetadataItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SearchCommonConsistencyLevel?), TypeInfoPropertyName = "NullableSearchCommonConsistencyLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SearchReferenceSelectorReturnMetadataItem?), TypeInfoPropertyName = "NullableSearchReferenceSelectorReturnMetadataItem2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SearchHybridRequest?), TypeInfoPropertyName = "NullableSearchHybridRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SearchHybridRequestVariant2FusionType?), TypeInfoPropertyName = "NullableSearchHybridRequestVariant2FusionType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SearchNearObjectRequest?), TypeInfoPropertyName = "NullableSearchNearObjectRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SearchNearTextRequest?), TypeInfoPropertyName = "NullableSearchNearTextRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SearchNearVectorRequest?), TypeInfoPropertyName = "NullableSearchNearVectorRequest2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.ErrorResponseErrorItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.WhereFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<bool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.SearchReferenceSelector>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.SearchCommonReturnMetadataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.SearchReferenceSelectorReturnMetadataItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.SearchResultObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<global::Weaviate.SearchResultReference>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.SearchResultReference>))]
    internal sealed partial class SearchSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SearchSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SearchSourceGenerationContext Default { get; } = new(DefaultOptions);

        private SearchSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
            : base(options)
        {
        }

        /// <inheritdoc />
        protected override global::System.Text.Json.JsonSerializerOptions? GeneratedSerializerOptions => DefaultOptions;

        /// <inheritdoc />
        public override global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(global::System.Type type)
        {
            return Resolver.GetTypeInfo(type, Options);
        }

        /// <summary>
        /// Adds this package's converters to <paramref name="options"/>.
        /// </summary>
        /// <remarks>
        /// A converter has to be on the options a chained resolver builds its JsonTypeInfo against,
        /// and a context resolves types from every package below it. Each package contributes only
        /// what it owns and calls down the chain for the rest, so the family's converter table is
        /// written once rather than copied into all of them.
        /// </remarks>
        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        public static void AddConverters(global::System.Text.Json.JsonSerializerOptions options)
        {
            options.Converters.Add(new global::Weaviate.JsonConverters.SearchBm25RequestJsonConverter());
            options.Converters.Add(new global::Weaviate.JsonConverters.SearchHybridRequestJsonConverter());
            options.Converters.Add(new global::Weaviate.JsonConverters.SearchNearObjectRequestJsonConverter());
            options.Converters.Add(new global::Weaviate.JsonConverters.SearchNearTextRequestJsonConverter());
            options.Converters.Add(new global::Weaviate.JsonConverters.SearchNearVectorRequestJsonConverter());
            options.Converters.Add(new global::Weaviate.JsonConverters.UnixTimestampJsonConverter());
            options.Converters.Add(new LazyEnumJsonConverterFactory());
        }

        private static global::System.Text.Json.JsonSerializerOptions CreateDefaultOptions()
        {
            var options = new global::System.Text.Json.JsonSerializerOptions
            {
                DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
                TypeInfoResolver = Resolver,
            };
            AddConverters(options);

            return options;
        }


        private sealed class LazyEnumJsonConverterFactory : global::System.Text.Json.Serialization.JsonConverterFactory
        {
            public override bool CanConvert(global::System.Type typeToConvert)
            {
                return
                    typeToConvert == typeof(global::Weaviate.WhereFilterOperator)

                    || typeToConvert == typeof(global::Weaviate.WhereFilterOperator?)

                    || typeToConvert == typeof(global::Weaviate.SearchCommonReturnMetadataItem)

                    || typeToConvert == typeof(global::Weaviate.SearchCommonReturnMetadataItem?)

                    || typeToConvert == typeof(global::Weaviate.SearchCommonConsistencyLevel)

                    || typeToConvert == typeof(global::Weaviate.SearchCommonConsistencyLevel?)

                    || typeToConvert == typeof(global::Weaviate.SearchReferenceSelectorReturnMetadataItem)

                    || typeToConvert == typeof(global::Weaviate.SearchReferenceSelectorReturnMetadataItem?)

                    || typeToConvert == typeof(global::Weaviate.SearchHybridRequestVariant2FusionType)

                    || typeToConvert == typeof(global::Weaviate.SearchHybridRequestVariant2FusionType?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Weaviate.WhereFilterOperator))
                {
                    return new global::Weaviate.JsonConverters.WhereFilterOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.WhereFilterOperator?))
                {
                    return new global::Weaviate.JsonConverters.WhereFilterOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.SearchCommonReturnMetadataItem))
                {
                    return new global::Weaviate.JsonConverters.SearchCommonReturnMetadataItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.SearchCommonReturnMetadataItem?))
                {
                    return new global::Weaviate.JsonConverters.SearchCommonReturnMetadataItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.SearchCommonConsistencyLevel))
                {
                    return new global::Weaviate.JsonConverters.SearchCommonConsistencyLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.SearchCommonConsistencyLevel?))
                {
                    return new global::Weaviate.JsonConverters.SearchCommonConsistencyLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.SearchReferenceSelectorReturnMetadataItem))
                {
                    return new global::Weaviate.JsonConverters.SearchReferenceSelectorReturnMetadataItemJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.SearchReferenceSelectorReturnMetadataItem?))
                {
                    return new global::Weaviate.JsonConverters.SearchReferenceSelectorReturnMetadataItemNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.SearchHybridRequestVariant2FusionType))
                {
                    return new global::Weaviate.JsonConverters.SearchHybridRequestVariant2FusionTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.SearchHybridRequestVariant2FusionType?))
                {
                    return new global::Weaviate.JsonConverters.SearchHybridRequestVariant2FusionTypeNullableJsonConverter();
                }
                throw new global::System.NotSupportedException($"No generated enum converter is registered for '{typeToConvert}'.");
            }
        }

        private sealed class LazyChunkResolver : global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver
        {
            private readonly object _gate = new();
            private readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[] _resolvers = new global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver?[1];

            public global::System.Text.Json.Serialization.Metadata.JsonTypeInfo? GetTypeInfo(
                global::System.Type type,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                for (var index = 0; index < _resolvers.Length; index++)
                {
                    var typeInfo = GetResolver(index).GetTypeInfo(type, options);
                    if (typeInfo is not null)
                    {
                        return typeInfo;
                    }
                }

                return null;
            }

            private global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver GetResolver(int index)
            {
                var resolver = global::System.Threading.Volatile.Read(ref _resolvers[index]);
                if (resolver is not null)
                {
                    return resolver;
                }

                lock (_gate)
                {
                    return _resolvers[index] ??= CreateResolver(index);
                }
            }

            private static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver CreateResolver(int index)
            {
                return index switch
                {
                    0 => new SearchSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}
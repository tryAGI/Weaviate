
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.IndexStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.PropertyIndexStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.PropertyIndexStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.IndexStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.IndexStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.IndexStatusType), TypeInfoPropertyName = "IndexStatusType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.IndexStatusStatus), TypeInfoPropertyName = "IndexStatusStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.IndexStatusAlgorithm), TypeInfoPropertyName = "IndexStatusAlgorithm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.IndexStatusTargetAlgorithm), TypeInfoPropertyName = "IndexStatusTargetAlgorithm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.IndexUpsertRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.IndexUpdateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.UsageLimitExceededResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.UsageLimitExceededResponseErrorCode), TypeInfoPropertyName = "UsageLimitExceededResponseErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.UsageLimitExceededResponseLimit), TypeInfoPropertyName = "UsageLimitExceededResponseLimit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.RestrictionViolationResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.RestrictionViolationResponseErrorItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.RestrictionViolationResponseErrorItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.RestrictionViolationResponseErrorCode), TypeInfoPropertyName = "RestrictionViolationResponseErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.RestrictionViolationResponseRestriction), TypeInfoPropertyName = "RestrictionViolationResponseRestriction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.InvertedIndexConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BM25Config))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.StopwordConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.TokenizerUserDictConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.TokenizerUserDictConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationAsyncConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationConfigDeletionStrategy), TypeInfoPropertyName = "ReplicationConfigDeletionStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.TokenizerUserDictConfigReplacement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.TokenizerUserDictConfigReplacement))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.TextAnalyzerConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.TokenizeResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.PropertyTokenizeRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.MultiTenancyConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ObjectTtlConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.Schema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.Class>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.Class))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Weaviate.VectorConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.VectorConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.Property>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.Property))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.PropertyTokenization), TypeInfoPropertyName = "PropertyTokenization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.NestedProperty>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.NestedProperty))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.NestedPropertyTokenization), TypeInfoPropertyName = "NestedPropertyTokenization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.ShardStatusGetResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ShardStatusGetResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ShardStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.Tenant))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.TenantActivityStatus), TypeInfoPropertyName = "TenantActivityStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.Alias))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.AliasResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.Alias>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.Tenant>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.AliasesUpdateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SchemaObjectsIndexUpsertIndexName), TypeInfoPropertyName = "SchemaObjectsIndexUpsertIndexName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SchemaObjectsPropertiesDeleteIndexName), TypeInfoPropertyName = "SchemaObjectsPropertiesDeleteIndexName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SchemaObjectsIndexRebuildIndexName), TypeInfoPropertyName = "SchemaObjectsIndexRebuildIndexName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SchemaObjectsIndexCancelIndexName), TypeInfoPropertyName = "SchemaObjectsIndexCancelIndexName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.IndexStatusType?), TypeInfoPropertyName = "NullableIndexStatusType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.IndexStatusStatus?), TypeInfoPropertyName = "NullableIndexStatusStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.IndexStatusAlgorithm?), TypeInfoPropertyName = "NullableIndexStatusAlgorithm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.IndexStatusTargetAlgorithm?), TypeInfoPropertyName = "NullableIndexStatusTargetAlgorithm2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.UsageLimitExceededResponseErrorCode?), TypeInfoPropertyName = "NullableUsageLimitExceededResponseErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.UsageLimitExceededResponseLimit?), TypeInfoPropertyName = "NullableUsageLimitExceededResponseLimit2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.RestrictionViolationResponseErrorCode?), TypeInfoPropertyName = "NullableRestrictionViolationResponseErrorCode2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.RestrictionViolationResponseRestriction?), TypeInfoPropertyName = "NullableRestrictionViolationResponseRestriction2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationConfigDeletionStrategy?), TypeInfoPropertyName = "NullableReplicationConfigDeletionStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.PropertyTokenization?), TypeInfoPropertyName = "NullablePropertyTokenization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.NestedPropertyTokenization?), TypeInfoPropertyName = "NullableNestedPropertyTokenization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.TenantActivityStatus?), TypeInfoPropertyName = "NullableTenantActivityStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SchemaObjectsIndexUpsertIndexName?), TypeInfoPropertyName = "NullableSchemaObjectsIndexUpsertIndexName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SchemaObjectsPropertiesDeleteIndexName?), TypeInfoPropertyName = "NullableSchemaObjectsPropertiesDeleteIndexName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SchemaObjectsIndexRebuildIndexName?), TypeInfoPropertyName = "NullableSchemaObjectsIndexRebuildIndexName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.SchemaObjectsIndexCancelIndexName?), TypeInfoPropertyName = "NullableSchemaObjectsIndexCancelIndexName2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.ErrorResponseErrorItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.PropertyIndexStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.IndexStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.RestrictionViolationResponseErrorItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.TokenizerUserDictConfig>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.TokenizerUserDictConfigReplacement>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.Class>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.Property>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.NestedProperty>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.ShardStatusGetResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.Alias>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.Tenant>))]
    internal sealed partial class SchemaSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SchemaSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static SchemaSourceGenerationContext Default { get; } = new(DefaultOptions);

        private SchemaSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Weaviate.IndexStatusType)

                    || typeToConvert == typeof(global::Weaviate.IndexStatusType?)

                    || typeToConvert == typeof(global::Weaviate.IndexStatusStatus)

                    || typeToConvert == typeof(global::Weaviate.IndexStatusStatus?)

                    || typeToConvert == typeof(global::Weaviate.IndexStatusAlgorithm)

                    || typeToConvert == typeof(global::Weaviate.IndexStatusAlgorithm?)

                    || typeToConvert == typeof(global::Weaviate.IndexStatusTargetAlgorithm)

                    || typeToConvert == typeof(global::Weaviate.IndexStatusTargetAlgorithm?)

                    || typeToConvert == typeof(global::Weaviate.UsageLimitExceededResponseErrorCode)

                    || typeToConvert == typeof(global::Weaviate.UsageLimitExceededResponseErrorCode?)

                    || typeToConvert == typeof(global::Weaviate.UsageLimitExceededResponseLimit)

                    || typeToConvert == typeof(global::Weaviate.UsageLimitExceededResponseLimit?)

                    || typeToConvert == typeof(global::Weaviate.RestrictionViolationResponseErrorCode)

                    || typeToConvert == typeof(global::Weaviate.RestrictionViolationResponseErrorCode?)

                    || typeToConvert == typeof(global::Weaviate.RestrictionViolationResponseRestriction)

                    || typeToConvert == typeof(global::Weaviate.RestrictionViolationResponseRestriction?)

                    || typeToConvert == typeof(global::Weaviate.ReplicationConfigDeletionStrategy)

                    || typeToConvert == typeof(global::Weaviate.ReplicationConfigDeletionStrategy?)

                    || typeToConvert == typeof(global::Weaviate.PropertyTokenization)

                    || typeToConvert == typeof(global::Weaviate.PropertyTokenization?)

                    || typeToConvert == typeof(global::Weaviate.NestedPropertyTokenization)

                    || typeToConvert == typeof(global::Weaviate.NestedPropertyTokenization?)

                    || typeToConvert == typeof(global::Weaviate.TenantActivityStatus)

                    || typeToConvert == typeof(global::Weaviate.TenantActivityStatus?)

                    || typeToConvert == typeof(global::Weaviate.SchemaObjectsIndexUpsertIndexName)

                    || typeToConvert == typeof(global::Weaviate.SchemaObjectsIndexUpsertIndexName?)

                    || typeToConvert == typeof(global::Weaviate.SchemaObjectsPropertiesDeleteIndexName)

                    || typeToConvert == typeof(global::Weaviate.SchemaObjectsPropertiesDeleteIndexName?)

                    || typeToConvert == typeof(global::Weaviate.SchemaObjectsIndexRebuildIndexName)

                    || typeToConvert == typeof(global::Weaviate.SchemaObjectsIndexRebuildIndexName?)

                    || typeToConvert == typeof(global::Weaviate.SchemaObjectsIndexCancelIndexName)

                    || typeToConvert == typeof(global::Weaviate.SchemaObjectsIndexCancelIndexName?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Weaviate.IndexStatusType))
                {
                    return new global::Weaviate.JsonConverters.IndexStatusTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.IndexStatusType?))
                {
                    return new global::Weaviate.JsonConverters.IndexStatusTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.IndexStatusStatus))
                {
                    return new global::Weaviate.JsonConverters.IndexStatusStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.IndexStatusStatus?))
                {
                    return new global::Weaviate.JsonConverters.IndexStatusStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.IndexStatusAlgorithm))
                {
                    return new global::Weaviate.JsonConverters.IndexStatusAlgorithmJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.IndexStatusAlgorithm?))
                {
                    return new global::Weaviate.JsonConverters.IndexStatusAlgorithmNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.IndexStatusTargetAlgorithm))
                {
                    return new global::Weaviate.JsonConverters.IndexStatusTargetAlgorithmJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.IndexStatusTargetAlgorithm?))
                {
                    return new global::Weaviate.JsonConverters.IndexStatusTargetAlgorithmNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.UsageLimitExceededResponseErrorCode))
                {
                    return new global::Weaviate.JsonConverters.UsageLimitExceededResponseErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.UsageLimitExceededResponseErrorCode?))
                {
                    return new global::Weaviate.JsonConverters.UsageLimitExceededResponseErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.UsageLimitExceededResponseLimit))
                {
                    return new global::Weaviate.JsonConverters.UsageLimitExceededResponseLimitJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.UsageLimitExceededResponseLimit?))
                {
                    return new global::Weaviate.JsonConverters.UsageLimitExceededResponseLimitNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.RestrictionViolationResponseErrorCode))
                {
                    return new global::Weaviate.JsonConverters.RestrictionViolationResponseErrorCodeJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.RestrictionViolationResponseErrorCode?))
                {
                    return new global::Weaviate.JsonConverters.RestrictionViolationResponseErrorCodeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.RestrictionViolationResponseRestriction))
                {
                    return new global::Weaviate.JsonConverters.RestrictionViolationResponseRestrictionJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.RestrictionViolationResponseRestriction?))
                {
                    return new global::Weaviate.JsonConverters.RestrictionViolationResponseRestrictionNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.ReplicationConfigDeletionStrategy))
                {
                    return new global::Weaviate.JsonConverters.ReplicationConfigDeletionStrategyJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.ReplicationConfigDeletionStrategy?))
                {
                    return new global::Weaviate.JsonConverters.ReplicationConfigDeletionStrategyNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.PropertyTokenization))
                {
                    return new global::Weaviate.JsonConverters.PropertyTokenizationJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.PropertyTokenization?))
                {
                    return new global::Weaviate.JsonConverters.PropertyTokenizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.NestedPropertyTokenization))
                {
                    return new global::Weaviate.JsonConverters.NestedPropertyTokenizationJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.NestedPropertyTokenization?))
                {
                    return new global::Weaviate.JsonConverters.NestedPropertyTokenizationNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.TenantActivityStatus))
                {
                    return new global::Weaviate.JsonConverters.TenantActivityStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.TenantActivityStatus?))
                {
                    return new global::Weaviate.JsonConverters.TenantActivityStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.SchemaObjectsIndexUpsertIndexName))
                {
                    return new global::Weaviate.JsonConverters.SchemaObjectsIndexUpsertIndexNameJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.SchemaObjectsIndexUpsertIndexName?))
                {
                    return new global::Weaviate.JsonConverters.SchemaObjectsIndexUpsertIndexNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.SchemaObjectsPropertiesDeleteIndexName))
                {
                    return new global::Weaviate.JsonConverters.SchemaObjectsPropertiesDeleteIndexNameJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.SchemaObjectsPropertiesDeleteIndexName?))
                {
                    return new global::Weaviate.JsonConverters.SchemaObjectsPropertiesDeleteIndexNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.SchemaObjectsIndexRebuildIndexName))
                {
                    return new global::Weaviate.JsonConverters.SchemaObjectsIndexRebuildIndexNameJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.SchemaObjectsIndexRebuildIndexName?))
                {
                    return new global::Weaviate.JsonConverters.SchemaObjectsIndexRebuildIndexNameNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.SchemaObjectsIndexCancelIndexName))
                {
                    return new global::Weaviate.JsonConverters.SchemaObjectsIndexCancelIndexNameJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.SchemaObjectsIndexCancelIndexName?))
                {
                    return new global::Weaviate.JsonConverters.SchemaObjectsIndexCancelIndexNameNullableJsonConverter();
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
                    0 => new SchemaSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}
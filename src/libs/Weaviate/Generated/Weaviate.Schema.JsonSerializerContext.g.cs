
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Weaviate
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.ErrorResponseErrorItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ErrorResponseErrorItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.InvertedIndexConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BM25Config))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.StopwordConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationConfigDeletionStrategy), TypeInfoPropertyName = "ReplicationConfigDeletionStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.MultiTenancyConfig))]
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.TenantResponse), TypeInfoPropertyName = "TenantResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.TenantResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.Tenant>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationConfigDeletionStrategy?), TypeInfoPropertyName = "NullableReplicationConfigDeletionStrategy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.PropertyTokenization?), TypeInfoPropertyName = "NullablePropertyTokenization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.NestedPropertyTokenization?), TypeInfoPropertyName = "NullableNestedPropertyTokenization2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.TenantActivityStatus?), TypeInfoPropertyName = "NullableTenantActivityStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.TenantResponse?), TypeInfoPropertyName = "NullableTenantResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.ErrorResponseErrorItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.Class>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.Property>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.NestedProperty>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.ShardStatusGetResponse>))]
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
            options.Converters.Add(new global::Weaviate.JsonConverters.TenantResponseJsonConverter());
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
                    typeToConvert == typeof(global::Weaviate.ReplicationConfigDeletionStrategy)

                    || typeToConvert == typeof(global::Weaviate.ReplicationConfigDeletionStrategy?)

                    || typeToConvert == typeof(global::Weaviate.PropertyTokenization)

                    || typeToConvert == typeof(global::Weaviate.PropertyTokenization?)

                    || typeToConvert == typeof(global::Weaviate.NestedPropertyTokenization)

                    || typeToConvert == typeof(global::Weaviate.NestedPropertyTokenization?)

                    || typeToConvert == typeof(global::Weaviate.TenantActivityStatus)

                    || typeToConvert == typeof(global::Weaviate.TenantActivityStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
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

#nullable enable

namespace Weaviate
{
    /// <summary>
    ///
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull
    )]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>), TypeInfoPropertyName = "DictionaryStringString_System_Collections_Generic_Dictionary_string_string")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "SystemCollectionsGeneric_ObjectList")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string[]))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.ErrorResponseErrorItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ErrorResponseErrorItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationReplicateReplicaRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationReplicateReplicaRequestType), TypeInfoPropertyName = "ReplicationReplicateReplicaRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationReplicateReplicaResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationShardingStateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationShardingState))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationScalePlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Weaviate.ReplicationScalePlanShardScaleActions2>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationScalePlanShardScaleActions2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string?>), TypeInfoPropertyName = "DictionaryStringString_System_Collections_Generic_Dictionary_string_string_3")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationScaleApplyResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationShardReplicas))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.ReplicationShardReplicas>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationReplicateDetailsReplicaStatusError))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationReplicateDetailsReplicaStatus))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationReplicateDetailsReplicaStatusState), TypeInfoPropertyName = "ReplicationReplicateDetailsReplicaStatusState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.ReplicationReplicateDetailsReplicaStatusError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationReplicateDetailsReplicaResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationReplicateDetailsReplicaResponseType), TypeInfoPropertyName = "ReplicationReplicateDetailsReplicaResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.ReplicationReplicateDetailsReplicaStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationReplicateForceDeleteRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationReplicateForceDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationRebalanceRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationRebalanceCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationRebalancePlan))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationRebalancePlanState), TypeInfoPropertyName = "ReplicationRebalancePlanState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.ReplicationRebalancePlanNode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationRebalancePlanNode))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.ReplicationRebalancePlanBaselineItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationRebalancePlanBaselineItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.ReplicationReplicateDetailsReplicaResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationReplicateReplicaRequestType?), TypeInfoPropertyName = "NullableReplicationReplicateReplicaRequestType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTimeOffset?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationReplicateDetailsReplicaStatusState?), TypeInfoPropertyName = "NullableReplicationReplicateDetailsReplicaStatusState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationReplicateDetailsReplicaResponseType?), TypeInfoPropertyName = "NullableReplicationReplicateDetailsReplicaResponseType2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ReplicationRebalancePlanState?), TypeInfoPropertyName = "NullableReplicationRebalancePlanState2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.ErrorResponseErrorItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::System.Guid>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.ReplicationShardReplicas>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.ReplicationReplicateDetailsReplicaStatusError>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.ReplicationReplicateDetailsReplicaStatus>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.ReplicationRebalancePlanNode>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.ReplicationRebalancePlanBaselineItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.ReplicationReplicateDetailsReplicaResponse>))]
    internal sealed partial class ReplicationSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ReplicationSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();

        [global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
        internal static global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver TypeInfoResolver => Resolver;


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static ReplicationSourceGenerationContext Default { get; } = new(DefaultOptions);

        private ReplicationSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Weaviate.ReplicationReplicateReplicaRequestType)

                    || typeToConvert == typeof(global::Weaviate.ReplicationReplicateReplicaRequestType?)

                    || typeToConvert == typeof(global::Weaviate.ReplicationReplicateDetailsReplicaStatusState)

                    || typeToConvert == typeof(global::Weaviate.ReplicationReplicateDetailsReplicaStatusState?)

                    || typeToConvert == typeof(global::Weaviate.ReplicationReplicateDetailsReplicaResponseType)

                    || typeToConvert == typeof(global::Weaviate.ReplicationReplicateDetailsReplicaResponseType?)

                    || typeToConvert == typeof(global::Weaviate.ReplicationRebalancePlanState)

                    || typeToConvert == typeof(global::Weaviate.ReplicationRebalancePlanState?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Weaviate.ReplicationReplicateReplicaRequestType))
                {
                    return new global::Weaviate.JsonConverters.ReplicationReplicateReplicaRequestTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.ReplicationReplicateReplicaRequestType?))
                {
                    return new global::Weaviate.JsonConverters.ReplicationReplicateReplicaRequestTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.ReplicationReplicateDetailsReplicaStatusState))
                {
                    return new global::Weaviate.JsonConverters.ReplicationReplicateDetailsReplicaStatusStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.ReplicationReplicateDetailsReplicaStatusState?))
                {
                    return new global::Weaviate.JsonConverters.ReplicationReplicateDetailsReplicaStatusStateNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.ReplicationReplicateDetailsReplicaResponseType))
                {
                    return new global::Weaviate.JsonConverters.ReplicationReplicateDetailsReplicaResponseTypeJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.ReplicationReplicateDetailsReplicaResponseType?))
                {
                    return new global::Weaviate.JsonConverters.ReplicationReplicateDetailsReplicaResponseTypeNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.ReplicationRebalancePlanState))
                {
                    return new global::Weaviate.JsonConverters.ReplicationRebalancePlanStateJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.ReplicationRebalancePlanState?))
                {
                    return new global::Weaviate.JsonConverters.ReplicationRebalancePlanStateNullableJsonConverter();
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
                    0 => new ReplicationSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}

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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<object>), TypeInfoPropertyName = "ListObject_System_Collections_Generic_List_object")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.Object>), TypeInfoPropertyName = "ListObject_System_Collections_Generic_List_global_Weaviate_Object")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Text.Json.JsonElement?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<float>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.Vector))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.Dictionary<string, global::Weaviate.Vector>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.Deprecation))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.ErrorResponseErrorItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ErrorResponseErrorItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(object))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.Object), TypeInfoPropertyName = "Object_Weaviate_Object")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.VectorWeights))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.PropertySchema))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BatchReference))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BatchReferenceResponse), TypeInfoPropertyName = "BatchReferenceResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BatchReferenceResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BatchReferenceResponseVariant2Result))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BatchReferenceResponseVariant2ResultStatus), TypeInfoPropertyName = "BatchReferenceResponseVariant2ResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.GeoCoordinates))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ObjectsGetResponse), TypeInfoPropertyName = "ObjectsGetResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ObjectsGetResponseVariant2))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.Deprecation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ObjectsGetResponseVariant3))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ObjectsGetResponseVariant3Result))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ObjectsGetResponseVariant3ResultStatus), TypeInfoPropertyName = "ObjectsGetResponseVariant3ResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BatchDelete))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BatchDeleteMatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.WhereFilter))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BatchDeleteResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BatchDeleteResponseMatch))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BatchDeleteResponseResults))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.BatchDeleteResponseResultsObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BatchDeleteResponseResultsObject))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BatchDeleteResponseResultsObjectStatus), TypeInfoPropertyName = "BatchDeleteResponseResultsObjectStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.Object>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.WhereFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.WhereFilterOperator), TypeInfoPropertyName = "WhereFilterOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<bool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.WhereFilterGeoRange))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.WhereFilterGeoRangeDistance))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BatchObjectsCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.BatchObjectsCreateRequestField>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BatchObjectsCreateRequestField), TypeInfoPropertyName = "BatchObjectsCreateRequestField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.BatchReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.ObjectsGetResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.BatchReferenceResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(long?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(double?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Guid?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BatchReferenceResponse?), TypeInfoPropertyName = "NullableBatchReferenceResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BatchReferenceResponseVariant2ResultStatus?), TypeInfoPropertyName = "NullableBatchReferenceResponseVariant2ResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ObjectsGetResponse?), TypeInfoPropertyName = "NullableObjectsGetResponse2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ObjectsGetResponseVariant3ResultStatus?), TypeInfoPropertyName = "NullableObjectsGetResponseVariant3ResultStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BatchDeleteResponseResultsObjectStatus?), TypeInfoPropertyName = "NullableBatchDeleteResponseResultsObjectStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.WhereFilterOperator?), TypeInfoPropertyName = "NullableWhereFilterOperator2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BatchObjectsCreateRequestField?), TypeInfoPropertyName = "NullableBatchObjectsCreateRequestField2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<float>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.ErrorResponseErrorItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.Deprecation>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.BatchDeleteResponseResultsObject>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.WhereFilter>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<long>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<double>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<bool>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.BatchObjectsCreateRequestField>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.BatchReference>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.ObjectsGetResponse>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.BatchReferenceResponse>))]
    internal sealed partial class BatchSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BatchSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static BatchSourceGenerationContext Default { get; } = new(DefaultOptions);

        private BatchSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
            options.Converters.Add(new global::Weaviate.JsonConverters.BatchReferenceResponseJsonConverter());
            options.Converters.Add(new global::Weaviate.JsonConverters.ObjectsGetResponseJsonConverter());
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
                    typeToConvert == typeof(global::Weaviate.BatchReferenceResponseVariant2ResultStatus)

                    || typeToConvert == typeof(global::Weaviate.BatchReferenceResponseVariant2ResultStatus?)

                    || typeToConvert == typeof(global::Weaviate.ObjectsGetResponseVariant3ResultStatus)

                    || typeToConvert == typeof(global::Weaviate.ObjectsGetResponseVariant3ResultStatus?)

                    || typeToConvert == typeof(global::Weaviate.BatchDeleteResponseResultsObjectStatus)

                    || typeToConvert == typeof(global::Weaviate.BatchDeleteResponseResultsObjectStatus?)

                    || typeToConvert == typeof(global::Weaviate.WhereFilterOperator)

                    || typeToConvert == typeof(global::Weaviate.WhereFilterOperator?)

                    || typeToConvert == typeof(global::Weaviate.BatchObjectsCreateRequestField)

                    || typeToConvert == typeof(global::Weaviate.BatchObjectsCreateRequestField?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Weaviate.BatchReferenceResponseVariant2ResultStatus))
                {
                    return new global::Weaviate.JsonConverters.BatchReferenceResponseVariant2ResultStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.BatchReferenceResponseVariant2ResultStatus?))
                {
                    return new global::Weaviate.JsonConverters.BatchReferenceResponseVariant2ResultStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.ObjectsGetResponseVariant3ResultStatus))
                {
                    return new global::Weaviate.JsonConverters.ObjectsGetResponseVariant3ResultStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.ObjectsGetResponseVariant3ResultStatus?))
                {
                    return new global::Weaviate.JsonConverters.ObjectsGetResponseVariant3ResultStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.BatchDeleteResponseResultsObjectStatus))
                {
                    return new global::Weaviate.JsonConverters.BatchDeleteResponseResultsObjectStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.BatchDeleteResponseResultsObjectStatus?))
                {
                    return new global::Weaviate.JsonConverters.BatchDeleteResponseResultsObjectStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.WhereFilterOperator))
                {
                    return new global::Weaviate.JsonConverters.WhereFilterOperatorJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.WhereFilterOperator?))
                {
                    return new global::Weaviate.JsonConverters.WhereFilterOperatorNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.BatchObjectsCreateRequestField))
                {
                    return new global::Weaviate.JsonConverters.BatchObjectsCreateRequestFieldJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.BatchObjectsCreateRequestField?))
                {
                    return new global::Weaviate.JsonConverters.BatchObjectsCreateRequestFieldNullableJsonConverter();
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
                    0 => new BatchSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}
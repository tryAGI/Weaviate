
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
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ErrorResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.ErrorResponseErrorItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.ErrorResponseErrorItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BackupCreateStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BackupCreateStatusResponseStatus), TypeInfoPropertyName = "BackupCreateStatusResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BackupRestoreStatusResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BackupRestoreStatusResponseStatus), TypeInfoPropertyName = "BackupRestoreStatusResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BackupConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BackupConfigCompressionLevel), TypeInfoPropertyName = "BackupConfigCompressionLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.RestoreConfig))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BackupCreateRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BackupCreateResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BackupCreateResponseStatus), TypeInfoPropertyName = "BackupCreateResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Weaviate.BackupListResponseItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BackupListResponseItem))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BackupListResponseItemStatus), TypeInfoPropertyName = "BackupListResponseItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BackupRestoreRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BackupRestoreResponse))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BackupRestoreResponseStatus), TypeInfoPropertyName = "BackupRestoreResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int?))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BackupCreateStatusResponseStatus?), TypeInfoPropertyName = "NullableBackupCreateStatusResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BackupRestoreStatusResponseStatus?), TypeInfoPropertyName = "NullableBackupRestoreStatusResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BackupConfigCompressionLevel?), TypeInfoPropertyName = "NullableBackupConfigCompressionLevel2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BackupCreateResponseStatus?), TypeInfoPropertyName = "NullableBackupCreateResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BackupListResponseItemStatus?), TypeInfoPropertyName = "NullableBackupListResponseItemStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Weaviate.BackupRestoreResponseStatus?), TypeInfoPropertyName = "NullableBackupRestoreResponseStatus2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.ErrorResponseErrorItem>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Weaviate.BackupListResponseItem>))]
    internal sealed partial class BackupsSourceGenerationContextChunk0 : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BackupsSourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
        private static readonly global::System.Text.Json.Serialization.Metadata.IJsonTypeInfoResolver Resolver = new LazyChunkResolver();


        private static readonly global::System.Text.Json.JsonSerializerOptions DefaultOptions = CreateDefaultOptions();

        /// <summary>
        ///
        /// </summary>
        public static BackupsSourceGenerationContext Default { get; } = new(DefaultOptions);

        private BackupsSourceGenerationContext(global::System.Text.Json.JsonSerializerOptions options)
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
                    typeToConvert == typeof(global::Weaviate.BackupCreateStatusResponseStatus)

                    || typeToConvert == typeof(global::Weaviate.BackupCreateStatusResponseStatus?)

                    || typeToConvert == typeof(global::Weaviate.BackupRestoreStatusResponseStatus)

                    || typeToConvert == typeof(global::Weaviate.BackupRestoreStatusResponseStatus?)

                    || typeToConvert == typeof(global::Weaviate.BackupConfigCompressionLevel)

                    || typeToConvert == typeof(global::Weaviate.BackupConfigCompressionLevel?)

                    || typeToConvert == typeof(global::Weaviate.BackupCreateResponseStatus)

                    || typeToConvert == typeof(global::Weaviate.BackupCreateResponseStatus?)

                    || typeToConvert == typeof(global::Weaviate.BackupListResponseItemStatus)

                    || typeToConvert == typeof(global::Weaviate.BackupListResponseItemStatus?)

                    || typeToConvert == typeof(global::Weaviate.BackupRestoreResponseStatus)

                    || typeToConvert == typeof(global::Weaviate.BackupRestoreResponseStatus?);
            }

            public override global::System.Text.Json.Serialization.JsonConverter CreateConverter(
                global::System.Type typeToConvert,
                global::System.Text.Json.JsonSerializerOptions options)
            {
                if (typeToConvert == typeof(global::Weaviate.BackupCreateStatusResponseStatus))
                {
                    return new global::Weaviate.JsonConverters.BackupCreateStatusResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.BackupCreateStatusResponseStatus?))
                {
                    return new global::Weaviate.JsonConverters.BackupCreateStatusResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.BackupRestoreStatusResponseStatus))
                {
                    return new global::Weaviate.JsonConverters.BackupRestoreStatusResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.BackupRestoreStatusResponseStatus?))
                {
                    return new global::Weaviate.JsonConverters.BackupRestoreStatusResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.BackupConfigCompressionLevel))
                {
                    return new global::Weaviate.JsonConverters.BackupConfigCompressionLevelJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.BackupConfigCompressionLevel?))
                {
                    return new global::Weaviate.JsonConverters.BackupConfigCompressionLevelNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.BackupCreateResponseStatus))
                {
                    return new global::Weaviate.JsonConverters.BackupCreateResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.BackupCreateResponseStatus?))
                {
                    return new global::Weaviate.JsonConverters.BackupCreateResponseStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.BackupListResponseItemStatus))
                {
                    return new global::Weaviate.JsonConverters.BackupListResponseItemStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.BackupListResponseItemStatus?))
                {
                    return new global::Weaviate.JsonConverters.BackupListResponseItemStatusNullableJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.BackupRestoreResponseStatus))
                {
                    return new global::Weaviate.JsonConverters.BackupRestoreResponseStatusJsonConverter();
                }

                if (typeToConvert == typeof(global::Weaviate.BackupRestoreResponseStatus?))
                {
                    return new global::Weaviate.JsonConverters.BackupRestoreResponseStatusNullableJsonConverter();
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
                    0 => new BackupsSourceGenerationContextChunk0(new global::System.Text.Json.JsonSerializerOptions()),
                    _ => throw new global::System.ArgumentOutOfRangeException(nameof(index)),
                };
            }
        }
    }
}
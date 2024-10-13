
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Backup custom configuration
    /// </summary>
    public sealed partial class BackupConfig
    {
        /// <summary>
        /// Desired CPU core utilization ranging from 1%-80%<br/>
        /// Default Value: 50
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("CPUPercentage")]
        public int? CPUPercentage { get; set; } = 50;

        /// <summary>
        /// Aimed chunk size, with a minimum of 2MB, default of 128MB, and a maximum of 512MB. The actual chunk size may vary.<br/>
        /// Default Value: 128
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ChunkSize")]
        public int? ChunkSize { get; set; } = 128;

        /// <summary>
        /// Compression level used by compression algorithm<br/>
        /// Default Value: DefaultCompression
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("CompressionLevel")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weaviate.JsonConverters.BackupConfigCompressionLevelJsonConverter))]
        public global::Weaviate.BackupConfigCompressionLevel? CompressionLevel { get; set; } = global::Weaviate.BackupConfigCompressionLevel.DefaultCompression;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

    #if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
    #endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        public static global::Weaviate.BackupConfig? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::Weaviate.BackupConfig),
                jsonSerializerContext) as global::Weaviate.BackupConfig;
        }

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::Weaviate.BackupConfig? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::Weaviate.BackupConfig>(
                json,
                jsonSerializerOptions);
        }

    }
}
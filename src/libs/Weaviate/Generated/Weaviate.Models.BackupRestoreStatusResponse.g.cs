
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// The definition of a backup restore metadata
    /// </summary>
    public sealed partial class BackupRestoreStatusResponse
    {
        /// <summary>
        /// The ID of the backup. Must be URL-safe and work as a filesystem path, only lowercase, numbers, underscore, minus characters allowed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Backup backend name e.g. filesystem, gcs, s3.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backend")]
        public string? Backend { get; set; }

        /// <summary>
        /// destination path of backup files proper to selected backup backend
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        public string? Path { get; set; }

        /// <summary>
        /// error message if restoration failed
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// phase of backup restoration process<br/>
        /// Default Value: STARTED
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weaviate.JsonConverters.BackupRestoreStatusResponseStatusJsonConverter))]
        public global::Weaviate.BackupRestoreStatusResponseStatus? Status { get; set; } = global::Weaviate.BackupRestoreStatusResponseStatus.STARTED;

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

        public static global::Weaviate.BackupRestoreStatusResponse? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::Weaviate.BackupRestoreStatusResponse),
                jsonSerializerContext) as global::Weaviate.BackupRestoreStatusResponse;
        }

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::Weaviate.BackupRestoreStatusResponse? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::Weaviate.BackupRestoreStatusResponse>(
                json,
                jsonSerializerOptions);
        }

    }
}
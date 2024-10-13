
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Indicates the health of the schema in a cluster.
    /// </summary>
    public sealed partial class SchemaClusterStatus
    {
        /// <summary>
        /// True if the cluster is in sync, false if there is an issue (see error).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("healthy")]
        public bool? Healthy { get; set; }

        /// <summary>
        /// Contains the sync check error if one occurred
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Hostname of the coordinating node, i.e. the one that received the cluster. This can be useful information if the error message contains phrases such as 'other nodes agree, but local does not', etc.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hostname")]
        public string? Hostname { get; set; }

        /// <summary>
        /// Number of nodes that participated in the sync check
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodeCount")]
        public double? NodeCount { get; set; }

        /// <summary>
        /// The cluster check at startup can be ignored (to recover from an out-of-sync situation).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ignoreSchemaSync")]
        public bool? IgnoreSchemaSync { get; set; }

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

        public static global::Weaviate.SchemaClusterStatus? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::Weaviate.SchemaClusterStatus),
                jsonSerializerContext) as global::Weaviate.SchemaClusterStatus;
        }

#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::Weaviate.SchemaClusterStatus? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::Weaviate.SchemaClusterStatus>(
                json,
                jsonSerializerOptions);
        }

    }
}
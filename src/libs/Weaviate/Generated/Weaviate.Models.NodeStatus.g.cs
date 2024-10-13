
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// The definition of a backup node status response body
    /// </summary>
    public sealed partial class NodeStatus
    {
        /// <summary>
        /// The name of the node.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Node's status.<br/>
        /// Default Value: HEALTHY
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weaviate.JsonConverters.NodeStatusStatusJsonConverter))]
        public global::Weaviate.NodeStatusStatus? Status { get; set; } = global::Weaviate.NodeStatusStatus.HEALTHY;

        /// <summary>
        /// The version of Weaviate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("version")]
        public string? Version { get; set; }

        /// <summary>
        /// The gitHash of Weaviate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("gitHash")]
        public string? GitHash { get; set; }

        /// <summary>
        /// The summary of Weaviate's statistics.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stats")]
        public global::Weaviate.NodeStats? Stats { get; set; }

        /// <summary>
        /// The summary of a nodes batch queue congestion status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("batchStats")]
        public global::Weaviate.BatchStats? BatchStats { get; set; }

        /// <summary>
        /// The list of the shards with it's statistics.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shards")]
        public global::System.Collections.Generic.IList<global::Weaviate.NodeShardStatus>? Shards { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
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

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::Weaviate.NodeStatus? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::Weaviate.NodeStatus),
                jsonSerializerContext) as global::Weaviate.NodeStatus;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::Weaviate.NodeStatus? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::Weaviate.NodeStatus>(
                json,
                jsonSerializerOptions);
        }

    }
}
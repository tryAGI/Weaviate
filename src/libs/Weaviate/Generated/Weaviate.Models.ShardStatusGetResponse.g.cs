
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Response body of shard status get request
    /// </summary>
    public sealed partial class ShardStatusGetResponse
    {
        /// <summary>
        /// Name of the shard
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Deprecated: value is not consistent in replicated clusters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// Status of the shard on each of its replicas
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("per_node_status")]
        public global::System.Collections.Generic.Dictionary<string, string>? PerNodeStatus { get; set; }

        /// <summary>
        /// Deprecated: value is not consistent in replicated clusters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vectorQueueSize")]
        public int? VectorQueueSize { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ShardStatusGetResponse" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the shard
        /// </param>
        /// <param name="status">
        /// Deprecated: value is not consistent in replicated clusters.
        /// </param>
        /// <param name="perNodeStatus">
        /// Status of the shard on each of its replicas
        /// </param>
        /// <param name="vectorQueueSize">
        /// Deprecated: value is not consistent in replicated clusters.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ShardStatusGetResponse(
            string? name,
            string? status,
            global::System.Collections.Generic.Dictionary<string, string>? perNodeStatus,
            int? vectorQueueSize)
        {
            this.Name = name;
            this.Status = status;
            this.PerNodeStatus = perNodeStatus;
            this.VectorQueueSize = vectorQueueSize;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShardStatusGetResponse" /> class.
        /// </summary>
        public ShardStatusGetResponse()
        {
        }

    }
}
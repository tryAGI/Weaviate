
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Represents a shard and lists the nodes that currently host its replicas.
    /// </summary>
    public sealed partial class ReplicationShardReplicas
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shard")]
        public string? Shard { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replicas")]
        public global::System.Collections.Generic.IList<string>? Replicas { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicationShardReplicas" /> class.
        /// </summary>
        /// <param name="shard"></param>
        /// <param name="replicas"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReplicationShardReplicas(
            string? shard,
            global::System.Collections.Generic.IList<string>? replicas)
        {
            this.Shard = shard;
            this.Replicas = replicas;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicationShardReplicas" /> class.
        /// </summary>
        public ReplicationShardReplicas()
        {
        }

    }
}
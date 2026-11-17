
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Details the sharding layout for a specific collection, mapping each shard to its set of replicas across the cluster.
    /// </summary>
    public sealed partial class ReplicationShardingState
    {
        /// <summary>
        /// The name of the collection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collection")]
        public string? Collection { get; set; }

        /// <summary>
        /// An array detailing each shard within the collection and the nodes hosting its replicas.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shards")]
        public global::System.Collections.Generic.IList<global::Weaviate.ReplicationShardReplicas>? Shards { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicationShardingState" /> class.
        /// </summary>
        /// <param name="collection">
        /// The name of the collection.
        /// </param>
        /// <param name="shards">
        /// An array detailing each shard within the collection and the nodes hosting its replicas.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReplicationShardingState(
            string? collection,
            global::System.Collections.Generic.IList<global::Weaviate.ReplicationShardReplicas>? shards)
        {
            this.Collection = collection;
            this.Shards = shards;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicationShardingState" /> class.
        /// </summary>
        public ReplicationShardingState()
        {
        }

    }
}
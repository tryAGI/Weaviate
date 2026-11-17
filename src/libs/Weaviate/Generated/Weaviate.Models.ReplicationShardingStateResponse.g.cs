
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Provides the detailed sharding state for one or more collections, including the distribution of shards and their replicas across the cluster nodes.
    /// </summary>
    public sealed partial class ReplicationShardingStateResponse
    {
        /// <summary>
        /// Details the sharding layout for a specific collection, mapping each shard to its set of replicas across the cluster.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shardingState")]
        public global::Weaviate.ReplicationShardingState? ShardingState { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicationShardingStateResponse" /> class.
        /// </summary>
        /// <param name="shardingState">
        /// Details the sharding layout for a specific collection, mapping each shard to its set of replicas across the cluster.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReplicationShardingStateResponse(
            global::Weaviate.ReplicationShardingState? shardingState)
        {
            this.ShardingState = shardingState;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicationShardingStateResponse" /> class.
        /// </summary>
        public ReplicationShardingStateResponse()
        {
        }

    }
}
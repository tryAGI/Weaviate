
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Defines a complete plan for scaling replication within a collection. Each shard entry specifies nodes to remove and nodes to add. Added nodes may either be initialized empty (null) or created by replicating data from a source node specified as a string. If a source node is also marked for removal in the same shard, it represents a move operation and can only be used once as a source for that shard. If a source node is not marked for removal, it represents a copy operation and can be used as the source for multiple additions in that shard. Nodes listed in 'removeNodes' cannot also appear as targets in 'addNodes' for the same shard, and the same node cannot be specified for both addition and removal in a single shard.
    /// </summary>
    public sealed partial class ReplicationScalePlan
    {
        /// <summary>
        /// A unique identifier for this replication scaling plan, useful for tracking and auditing purposes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("planId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid PlanId { get; set; }

        /// <summary>
        /// The name of the collection to which this replication scaling plan applies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collection")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Collection { get; set; }

        /// <summary>
        /// A mapping of shard names to their corresponding scaling actions. Each key corresponds to a shard name, and its value defines which nodes should be removed and which should be added for that shard. If a source node listed for an addition is also in 'removeNodes' for the same shard, that addition is treated as a move operation. Such a node can appear only once as a source in that shard. Otherwise, if the source node is not being removed, it represents a copy operation and can be referenced multiple times as a source for additions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shardScaleActions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Weaviate.ReplicationScalePlanShardScaleActions2> ShardScaleActions { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicationScalePlan" /> class.
        /// </summary>
        /// <param name="planId">
        /// A unique identifier for this replication scaling plan, useful for tracking and auditing purposes.
        /// </param>
        /// <param name="collection">
        /// The name of the collection to which this replication scaling plan applies.
        /// </param>
        /// <param name="shardScaleActions">
        /// A mapping of shard names to their corresponding scaling actions. Each key corresponds to a shard name, and its value defines which nodes should be removed and which should be added for that shard. If a source node listed for an addition is also in 'removeNodes' for the same shard, that addition is treated as a move operation. Such a node can appear only once as a source in that shard. Otherwise, if the source node is not being removed, it represents a copy operation and can be referenced multiple times as a source for additions.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReplicationScalePlan(
            global::System.Guid planId,
            string collection,
            global::System.Collections.Generic.Dictionary<string, global::Weaviate.ReplicationScalePlanShardScaleActions2> shardScaleActions)
        {
            this.PlanId = planId;
            this.Collection = collection ?? throw new global::System.ArgumentNullException(nameof(collection));
            this.ShardScaleActions = shardScaleActions ?? throw new global::System.ArgumentNullException(nameof(shardScaleActions));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicationScalePlan" /> class.
        /// </summary>
        public ReplicationScalePlan()
        {
        }

    }
}
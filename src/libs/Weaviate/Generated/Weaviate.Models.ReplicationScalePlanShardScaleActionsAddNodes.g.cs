
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// A mapping of target node identifiers to their addition configuration. Each key represents a target node where a new replica will be added. The value may be null, which means an empty replica will be created, or a string specifying the source node from which shard data will be copied. If the source node is also marked for removal in the same shard, this addition is treated as a move operation, and that source node can only appear once as a source node for that shard. If the source node is not being removed, it can be used as the source for multiple additions (copy operations).
    /// </summary>
    public sealed partial class ReplicationScalePlanShardScaleActionsAddNodes
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}
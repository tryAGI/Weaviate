
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// A mapping of shard names to their corresponding scaling actions. Each key corresponds to a shard name, and its value defines which nodes should be removed and which should be added for that shard. If a source node listed for an addition is also in 'removeNodes' for the same shard, that addition is treated as a move operation. Such a node can appear only once as a source in that shard. Otherwise, if the source node is not being removed, it represents a copy operation and can be referenced multiple times as a source for additions.
    /// </summary>
    public sealed partial class ReplicationScalePlanShardScaleActions
    {

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

    }
}
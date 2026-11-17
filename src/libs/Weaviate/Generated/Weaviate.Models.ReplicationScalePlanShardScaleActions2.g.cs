
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Scaling actions for a single shard, including which nodes to remove and which to add. Nodes listed in 'removeNodes' cannot appear as targets in 'addNodes' for the same shard. If a source node is also marked for removal, it is treated as a move operation and can only appear once as a source node in that shard. A source node that is not being removed can appear multiple times as a source node for additions in that shard (copy operations).
    /// </summary>
    public sealed partial class ReplicationScalePlanShardScaleActions2
    {
        /// <summary>
        /// List of node identifiers from which replicas of this shard should be removed. Nodes listed here must not appear in 'addNodes' for the same shard, and cannot be used as a source node for any addition in this shard except in the implicit move case, where they appear as both a source and a node to remove.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("removeNodes")]
        public global::System.Collections.Generic.IList<string>? RemoveNodes { get; set; }

        /// <summary>
        /// A mapping of target node identifiers to their addition configuration. Each key represents a target node where a new replica will be added. The value may be null, which means an empty replica will be created, or a string specifying the source node from which shard data will be copied. If the source node is also marked for removal in the same shard, this addition is treated as a move operation, and that source node can only appear once as a source node for that shard. If the source node is not being removed, it can be used as the source for multiple additions (copy operations).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("addNodes")]
        public global::System.Collections.Generic.Dictionary<string, string?>? AddNodes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicationScalePlanShardScaleActions2" /> class.
        /// </summary>
        /// <param name="removeNodes">
        /// List of node identifiers from which replicas of this shard should be removed. Nodes listed here must not appear in 'addNodes' for the same shard, and cannot be used as a source node for any addition in this shard except in the implicit move case, where they appear as both a source and a node to remove.
        /// </param>
        /// <param name="addNodes">
        /// A mapping of target node identifiers to their addition configuration. Each key represents a target node where a new replica will be added. The value may be null, which means an empty replica will be created, or a string specifying the source node from which shard data will be copied. If the source node is also marked for removal in the same shard, this addition is treated as a move operation, and that source node can only appear once as a source node for that shard. If the source node is not being removed, it can be used as the source for multiple additions (copy operations).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReplicationScalePlanShardScaleActions2(
            global::System.Collections.Generic.IList<string>? removeNodes,
            global::System.Collections.Generic.Dictionary<string, string?>? addNodes)
        {
            this.RemoveNodes = removeNodes;
            this.AddNodes = addNodes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicationScalePlanShardScaleActions2" /> class.
        /// </summary>
        public ReplicationScalePlanShardScaleActions2()
        {
        }

    }
}
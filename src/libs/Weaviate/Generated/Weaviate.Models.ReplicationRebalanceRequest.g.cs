
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Specifies the nodes a rebalance plan moves shard replicas between. Replicas move from the source nodes to the target nodes.
    /// </summary>
    public sealed partial class ReplicationRebalanceRequest
    {
        /// <summary>
        /// The names of the nodes that replicas move away from. The list must be non-empty, must not repeat a node, and must not share a node with `targetNodes`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceNodes")]
        public global::System.Collections.Generic.IList<string>? SourceNodes { get; set; }

        /// <summary>
        /// The names of the nodes that replicas move to. The list must be non-empty, must not repeat a node, and must not share a node with `sourceNodes`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetNodes")]
        public global::System.Collections.Generic.IList<string>? TargetNodes { get; set; }

        /// <summary>
        /// The names of the collections the plan covers. The value is stored with the plan and does not yet affect planning.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collections")]
        public global::System.Collections.Generic.IList<string>? Collections { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicationRebalanceRequest" /> class.
        /// </summary>
        /// <param name="sourceNodes">
        /// The names of the nodes that replicas move away from. The list must be non-empty, must not repeat a node, and must not share a node with `targetNodes`.
        /// </param>
        /// <param name="targetNodes">
        /// The names of the nodes that replicas move to. The list must be non-empty, must not repeat a node, and must not share a node with `sourceNodes`.
        /// </param>
        /// <param name="collections">
        /// The names of the collections the plan covers. The value is stored with the plan and does not yet affect planning.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReplicationRebalanceRequest(
            global::System.Collections.Generic.IList<string>? sourceNodes,
            global::System.Collections.Generic.IList<string>? targetNodes,
            global::System.Collections.Generic.IList<string>? collections)
        {
            this.SourceNodes = sourceNodes;
            this.TargetNodes = targetNodes;
            this.Collections = collections;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicationRebalanceRequest" /> class.
        /// </summary>
        public ReplicationRebalanceRequest()
        {
        }

    }
}
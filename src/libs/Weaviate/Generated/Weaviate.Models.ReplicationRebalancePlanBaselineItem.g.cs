
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// One node's measured load.
    /// </summary>
    public sealed partial class ReplicationRebalancePlanBaselineItem
    {
        /// <summary>
        /// The name of the node.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node")]
        public string? Node { get; set; }

        /// <summary>
        /// The node's used disk bytes divided by its disk usage warning threshold in bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diskUtilisation")]
        public double? DiskUtilisation { get; set; }

        /// <summary>
        /// The number of shard replicas the node hosts, not counting replicas of FROZEN tenants.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replicaCount")]
        public int? ReplicaCount { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicationRebalancePlanBaselineItem" /> class.
        /// </summary>
        /// <param name="node">
        /// The name of the node.
        /// </param>
        /// <param name="diskUtilisation">
        /// The node's used disk bytes divided by its disk usage warning threshold in bytes.
        /// </param>
        /// <param name="replicaCount">
        /// The number of shard replicas the node hosts, not counting replicas of FROZEN tenants.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReplicationRebalancePlanBaselineItem(
            string? node,
            double? diskUtilisation,
            int? replicaCount)
        {
            this.Node = node;
            this.DiskUtilisation = diskUtilisation;
            this.ReplicaCount = replicaCount;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicationRebalancePlanBaselineItem" /> class.
        /// </summary>
        public ReplicationRebalancePlanBaselineItem()
        {
        }

    }
}
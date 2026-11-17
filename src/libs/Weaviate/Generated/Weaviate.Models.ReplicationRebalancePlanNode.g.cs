
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// One node's resource measurement.
    /// </summary>
    public sealed partial class ReplicationRebalancePlanNode
    {
        /// <summary>
        /// The name of the node.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node")]
        public string? Node { get; set; }

        /// <summary>
        /// The total size in bytes of the disk holding the node's data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diskTotalBytes")]
        public long? DiskTotalBytes { get; set; }

        /// <summary>
        /// The free bytes on the disk holding the node's data. The count includes blocks reserved for root.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diskAvailableBytes")]
        public long? DiskAvailableBytes { get; set; }

        /// <summary>
        /// The node's disk usage warning threshold, as a percentage of the disk's total size.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("diskWarningPercentage")]
        public long? DiskWarningPercentage { get; set; }

        /// <summary>
        /// The node's Go runtime memory limit in bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memoryLimitBytes")]
        public long? MemoryLimitBytes { get; set; }

        /// <summary>
        /// The number of replication engine workers configured on the node.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replicationWorkers")]
        public int? ReplicationWorkers { get; set; }

        /// <summary>
        /// Why the node could not be measured. Empty when the measurement succeeded.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public string? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicationRebalancePlanNode" /> class.
        /// </summary>
        /// <param name="node">
        /// The name of the node.
        /// </param>
        /// <param name="diskTotalBytes">
        /// The total size in bytes of the disk holding the node's data.
        /// </param>
        /// <param name="diskAvailableBytes">
        /// The free bytes on the disk holding the node's data. The count includes blocks reserved for root.
        /// </param>
        /// <param name="diskWarningPercentage">
        /// The node's disk usage warning threshold, as a percentage of the disk's total size.
        /// </param>
        /// <param name="memoryLimitBytes">
        /// The node's Go runtime memory limit in bytes.
        /// </param>
        /// <param name="replicationWorkers">
        /// The number of replication engine workers configured on the node.
        /// </param>
        /// <param name="error">
        /// Why the node could not be measured. Empty when the measurement succeeded.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReplicationRebalancePlanNode(
            string? node,
            long? diskTotalBytes,
            long? diskAvailableBytes,
            long? diskWarningPercentage,
            long? memoryLimitBytes,
            int? replicationWorkers,
            string? error)
        {
            this.Node = node;
            this.DiskTotalBytes = diskTotalBytes;
            this.DiskAvailableBytes = diskAvailableBytes;
            this.DiskWarningPercentage = diskWarningPercentage;
            this.MemoryLimitBytes = memoryLimitBytes;
            this.ReplicationWorkers = replicationWorkers;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicationRebalancePlanNode" /> class.
        /// </summary>
        public ReplicationRebalancePlanNode()
        {
        }

    }
}
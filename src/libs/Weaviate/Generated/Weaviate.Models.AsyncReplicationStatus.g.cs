
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// The status of the async replication.
    /// </summary>
    public sealed partial class AsyncReplicationStatus
    {
        /// <summary>
        /// The number of objects propagated in the most recent iteration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("objectsPropagated")]
        public double? ObjectsPropagated { get; set; }

        /// <summary>
        /// The start time of the most recent iteration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startDiffTimeUnixMillis")]
        public double? StartDiffTimeUnixMillis { get; set; }

        /// <summary>
        /// The target node of the replication, if set, otherwise empty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetNode")]
        public string? TargetNode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncReplicationStatus" /> class.
        /// </summary>
        /// <param name="objectsPropagated">
        /// The number of objects propagated in the most recent iteration.
        /// </param>
        /// <param name="startDiffTimeUnixMillis">
        /// The start time of the most recent iteration.
        /// </param>
        /// <param name="targetNode">
        /// The target node of the replication, if set, otherwise empty.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AsyncReplicationStatus(
            double? objectsPropagated,
            double? startDiffTimeUnixMillis,
            string? targetNode)
        {
            this.ObjectsPropagated = objectsPropagated;
            this.StartDiffTimeUnixMillis = startDiffTimeUnixMillis;
            this.TargetNode = targetNode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AsyncReplicationStatus" /> class.
        /// </summary>
        public AsyncReplicationStatus()
        {
        }

    }
}
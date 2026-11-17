
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Represents the current or historical status of a shard replica involved in a replication operation, including its operational state and any associated errors.
    /// </summary>
    public sealed partial class ReplicationReplicateDetailsReplicaStatus
    {
        /// <summary>
        /// The current operational state of the replica during the replication process.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weaviate.JsonConverters.ReplicationReplicateDetailsReplicaStatusStateJsonConverter))]
        public global::Weaviate.ReplicationReplicateDetailsReplicaStatusState? State { get; set; }

        /// <summary>
        /// The UNIX timestamp in ms when this state was first entered. This is an approximate time and so should not be used for precise timing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("whenStartedUnixMs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weaviate.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? WhenStartedUnixMs { get; set; }

        /// <summary>
        /// A list of error messages encountered by this replica during the replication operation, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("errors")]
        public global::System.Collections.Generic.IList<global::Weaviate.ReplicationReplicateDetailsReplicaStatusError>? Errors { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicationReplicateDetailsReplicaStatus" /> class.
        /// </summary>
        /// <param name="state">
        /// The current operational state of the replica during the replication process.
        /// </param>
        /// <param name="whenStartedUnixMs">
        /// The UNIX timestamp in ms when this state was first entered. This is an approximate time and so should not be used for precise timing.
        /// </param>
        /// <param name="errors">
        /// A list of error messages encountered by this replica during the replication operation, if any.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReplicationReplicateDetailsReplicaStatus(
            global::Weaviate.ReplicationReplicateDetailsReplicaStatusState? state,
            global::System.DateTimeOffset? whenStartedUnixMs,
            global::System.Collections.Generic.IList<global::Weaviate.ReplicationReplicateDetailsReplicaStatusError>? errors)
        {
            this.State = state;
            this.WhenStartedUnixMs = whenStartedUnixMs;
            this.Errors = errors;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicationReplicateDetailsReplicaStatus" /> class.
        /// </summary>
        public ReplicationReplicateDetailsReplicaStatus()
        {
        }

    }
}
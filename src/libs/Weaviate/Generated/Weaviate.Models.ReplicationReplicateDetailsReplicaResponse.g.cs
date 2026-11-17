
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Provides a comprehensive overview of a specific replication operation, detailing its unique ID, the involved collection, shard, source and target nodes, transfer type, current status, and optionally, its status history.
    /// </summary>
    public sealed partial class ReplicationReplicateDetailsReplicaResponse
    {
        /// <summary>
        /// The unique identifier (ID) of this specific replication operation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// The name of the shard involved in this replication operation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shard")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Shard { get; set; }

        /// <summary>
        /// The name of the collection to which the shard being replicated belongs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collection")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Collection { get; set; }

        /// <summary>
        /// The identifier of the node from which the replica is being moved or copied (the source node).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceNode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceNode { get; set; }

        /// <summary>
        /// The identifier of the node to which the replica is being moved or copied (the target node).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetNode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetNode { get; set; }

        /// <summary>
        /// Indicates whether the operation is a `COPY` (source replica remains) or a `MOVE` (source replica is removed after successful transfer).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weaviate.JsonConverters.ReplicationReplicateDetailsReplicaResponseTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Weaviate.ReplicationReplicateDetailsReplicaResponseType Type { get; set; }

        /// <summary>
        /// Whether the replica operation can't be cancelled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("uncancelable")]
        public bool? Uncancelable { get; set; }

        /// <summary>
        /// Whether the replica operation is scheduled for cancellation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheduledForCancel")]
        public bool? ScheduledForCancel { get; set; }

        /// <summary>
        /// Whether the replica operation is scheduled for deletion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scheduledForDelete")]
        public bool? ScheduledForDelete { get; set; }

        /// <summary>
        /// Represents the current or historical status of a shard replica involved in a replication operation, including its operational state and any associated errors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Weaviate.ReplicationReplicateDetailsReplicaStatus Status { get; set; }

        /// <summary>
        /// An array detailing the historical sequence of statuses the replication operation has transitioned through, if requested and available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("statusHistory")]
        public global::System.Collections.Generic.IList<global::Weaviate.ReplicationReplicateDetailsReplicaStatus>? StatusHistory { get; set; }

        /// <summary>
        /// The UNIX timestamp in ms when the replication operation was initiated. This is an approximate time and so should not be used for precise timing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("whenStartedUnixMs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weaviate.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? WhenStartedUnixMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicationReplicateDetailsReplicaResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier (ID) of this specific replication operation.
        /// </param>
        /// <param name="shard">
        /// The name of the shard involved in this replication operation.
        /// </param>
        /// <param name="collection">
        /// The name of the collection to which the shard being replicated belongs.
        /// </param>
        /// <param name="sourceNode">
        /// The identifier of the node from which the replica is being moved or copied (the source node).
        /// </param>
        /// <param name="targetNode">
        /// The identifier of the node to which the replica is being moved or copied (the target node).
        /// </param>
        /// <param name="type">
        /// Indicates whether the operation is a `COPY` (source replica remains) or a `MOVE` (source replica is removed after successful transfer).
        /// </param>
        /// <param name="status">
        /// Represents the current or historical status of a shard replica involved in a replication operation, including its operational state and any associated errors.
        /// </param>
        /// <param name="uncancelable">
        /// Whether the replica operation can't be cancelled.
        /// </param>
        /// <param name="scheduledForCancel">
        /// Whether the replica operation is scheduled for cancellation.
        /// </param>
        /// <param name="scheduledForDelete">
        /// Whether the replica operation is scheduled for deletion.
        /// </param>
        /// <param name="statusHistory">
        /// An array detailing the historical sequence of statuses the replication operation has transitioned through, if requested and available.
        /// </param>
        /// <param name="whenStartedUnixMs">
        /// The UNIX timestamp in ms when the replication operation was initiated. This is an approximate time and so should not be used for precise timing.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReplicationReplicateDetailsReplicaResponse(
            global::System.Guid id,
            string shard,
            string collection,
            string sourceNode,
            string targetNode,
            global::Weaviate.ReplicationReplicateDetailsReplicaResponseType type,
            global::Weaviate.ReplicationReplicateDetailsReplicaStatus status,
            bool? uncancelable,
            bool? scheduledForCancel,
            bool? scheduledForDelete,
            global::System.Collections.Generic.IList<global::Weaviate.ReplicationReplicateDetailsReplicaStatus>? statusHistory,
            global::System.DateTimeOffset? whenStartedUnixMs)
        {
            this.Id = id;
            this.Shard = shard ?? throw new global::System.ArgumentNullException(nameof(shard));
            this.Collection = collection ?? throw new global::System.ArgumentNullException(nameof(collection));
            this.SourceNode = sourceNode ?? throw new global::System.ArgumentNullException(nameof(sourceNode));
            this.TargetNode = targetNode ?? throw new global::System.ArgumentNullException(nameof(targetNode));
            this.Type = type;
            this.Uncancelable = uncancelable;
            this.ScheduledForCancel = scheduledForCancel;
            this.ScheduledForDelete = scheduledForDelete;
            this.Status = status ?? throw new global::System.ArgumentNullException(nameof(status));
            this.StatusHistory = statusHistory;
            this.WhenStartedUnixMs = whenStartedUnixMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicationReplicateDetailsReplicaResponse" /> class.
        /// </summary>
        public ReplicationReplicateDetailsReplicaResponse()
        {
        }

    }
}
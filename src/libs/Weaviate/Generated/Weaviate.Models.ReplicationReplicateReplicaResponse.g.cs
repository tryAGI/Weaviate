
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Contains the unique identifier for a successfully initiated asynchronous replica movement operation. This ID can be used to track the progress of the operation.
    /// </summary>
    public sealed partial class ReplicationReplicateReplicaResponse
    {
        /// <summary>
        /// The unique identifier (ID) assigned to the registered replication operation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicationReplicateReplicaResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier (ID) assigned to the registered replication operation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReplicationReplicateReplicaResponse(
            global::System.Guid id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicationReplicateReplicaResponse" /> class.
        /// </summary>
        public ReplicationReplicateReplicaResponse()
        {
        }

    }
}
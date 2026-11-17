
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Represents an error encountered during a replication operation, including its timestamp and a human-readable message.
    /// </summary>
    public sealed partial class ReplicationReplicateDetailsReplicaStatusError
    {
        /// <summary>
        /// The unix timestamp in ms when the error occurred. This is an approximate time and so should not be used for precise timing.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("whenErroredUnixMs")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weaviate.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? WhenErroredUnixMs { get; set; }

        /// <summary>
        /// A human-readable message describing the error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicationReplicateDetailsReplicaStatusError" /> class.
        /// </summary>
        /// <param name="whenErroredUnixMs">
        /// The unix timestamp in ms when the error occurred. This is an approximate time and so should not be used for precise timing.
        /// </param>
        /// <param name="message">
        /// A human-readable message describing the error.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReplicationReplicateDetailsReplicaStatusError(
            global::System.DateTimeOffset? whenErroredUnixMs,
            string? message)
        {
            this.WhenErroredUnixMs = whenErroredUnixMs;
            this.Message = message;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicationReplicateDetailsReplicaStatusError" /> class.
        /// </summary>
        public ReplicationReplicateDetailsReplicaStatusError()
        {
        }

    }
}
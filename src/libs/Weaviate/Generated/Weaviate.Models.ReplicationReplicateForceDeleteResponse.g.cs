
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Provides the UUIDs that were successfully force deleted as part of the replication operation. If dryRun is true, this will return the expected outcome without actually deleting anything.
    /// </summary>
    public sealed partial class ReplicationReplicateForceDeleteResponse
    {
        /// <summary>
        /// The unique identifiers (IDs) of the replication operations that were forcefully deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        public global::System.Collections.Generic.IList<global::System.Guid>? Deleted { get; set; }

        /// <summary>
        /// Indicates whether the operation was a dry run (true) or an actual deletion (false).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dryRun")]
        public bool? DryRun { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicationReplicateForceDeleteResponse" /> class.
        /// </summary>
        /// <param name="deleted">
        /// The unique identifiers (IDs) of the replication operations that were forcefully deleted.
        /// </param>
        /// <param name="dryRun">
        /// Indicates whether the operation was a dry run (true) or an actual deletion (false).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReplicationReplicateForceDeleteResponse(
            global::System.Collections.Generic.IList<global::System.Guid>? deleted,
            bool? dryRun)
        {
            this.Deleted = deleted;
            this.DryRun = dryRun;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicationReplicateForceDeleteResponse" /> class.
        /// </summary>
        public ReplicationReplicateForceDeleteResponse()
        {
        }

    }
}
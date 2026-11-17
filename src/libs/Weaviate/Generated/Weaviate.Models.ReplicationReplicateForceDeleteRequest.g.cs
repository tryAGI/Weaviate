
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Specifies the parameters available when force deleting replication operations.
    /// </summary>
    public sealed partial class ReplicationReplicateForceDeleteRequest
    {
        /// <summary>
        /// The unique identifier (ID) of the replication operation to be forcefully deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// The name of the collection to which the shard being replicated belongs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collection")]
        public string? Collection { get; set; }

        /// <summary>
        /// The identifier of the shard involved in the replication operations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shard")]
        public string? Shard { get; set; }

        /// <summary>
        /// The name of the target node where the replication operations are registered.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node")]
        public string? Node { get; set; }

        /// <summary>
        /// If true, the operation will not actually delete anything but will return the expected outcome of the deletion.<br/>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("dryRun")]
        public bool? DryRun { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicationReplicateForceDeleteRequest" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier (ID) of the replication operation to be forcefully deleted.
        /// </param>
        /// <param name="collection">
        /// The name of the collection to which the shard being replicated belongs.
        /// </param>
        /// <param name="shard">
        /// The identifier of the shard involved in the replication operations.
        /// </param>
        /// <param name="node">
        /// The name of the target node where the replication operations are registered.
        /// </param>
        /// <param name="dryRun">
        /// If true, the operation will not actually delete anything but will return the expected outcome of the deletion.<br/>
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReplicationReplicateForceDeleteRequest(
            global::System.Guid? id,
            string? collection,
            string? shard,
            string? node,
            bool? dryRun)
        {
            this.Id = id;
            this.Collection = collection;
            this.Shard = shard;
            this.Node = node;
            this.DryRun = dryRun;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicationReplicateForceDeleteRequest" /> class.
        /// </summary>
        public ReplicationReplicateForceDeleteRequest()
        {
        }

    }
}
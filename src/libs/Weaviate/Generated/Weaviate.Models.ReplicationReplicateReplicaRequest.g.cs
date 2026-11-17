
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Specifies the parameters required to initiate a shard replica movement operation between two nodes for a given collection and shard. This request defines the source and target node, the collection and type of transfer.
    /// </summary>
    public sealed partial class ReplicationReplicateReplicaRequest
    {
        /// <summary>
        /// The name of the Weaviate node currently hosting the shard replica that needs to be moved or copied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sourceNode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SourceNode { get; set; }

        /// <summary>
        /// The name of the Weaviate node where the new shard replica will be created as part of the movement or copy operation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetNode")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string TargetNode { get; set; }

        /// <summary>
        /// The name of the collection to which the target shard belongs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collection")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Collection { get; set; }

        /// <summary>
        /// The name of the shard whose replica is to be moved or copied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shard")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Shard { get; set; }

        /// <summary>
        /// Specifies the type of replication operation to perform. `COPY` creates a new replica on the target node while keeping the source replica. `MOVE` creates a new replica on the target node and then removes the source replica upon successful completion. Defaults to `COPY` if omitted.<br/>
        /// Default Value: COPY
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weaviate.JsonConverters.ReplicationReplicateReplicaRequestTypeJsonConverter))]
        public global::Weaviate.ReplicationReplicateReplicaRequestType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicationReplicateReplicaRequest" /> class.
        /// </summary>
        /// <param name="sourceNode">
        /// The name of the Weaviate node currently hosting the shard replica that needs to be moved or copied.
        /// </param>
        /// <param name="targetNode">
        /// The name of the Weaviate node where the new shard replica will be created as part of the movement or copy operation.
        /// </param>
        /// <param name="collection">
        /// The name of the collection to which the target shard belongs.
        /// </param>
        /// <param name="shard">
        /// The name of the shard whose replica is to be moved or copied.
        /// </param>
        /// <param name="type">
        /// Specifies the type of replication operation to perform. `COPY` creates a new replica on the target node while keeping the source replica. `MOVE` creates a new replica on the target node and then removes the source replica upon successful completion. Defaults to `COPY` if omitted.<br/>
        /// Default Value: COPY
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReplicationReplicateReplicaRequest(
            string sourceNode,
            string targetNode,
            string collection,
            string shard,
            global::Weaviate.ReplicationReplicateReplicaRequestType? type)
        {
            this.SourceNode = sourceNode ?? throw new global::System.ArgumentNullException(nameof(sourceNode));
            this.TargetNode = targetNode ?? throw new global::System.ArgumentNullException(nameof(targetNode));
            this.Collection = collection ?? throw new global::System.ArgumentNullException(nameof(collection));
            this.Shard = shard ?? throw new global::System.ArgumentNullException(nameof(shard));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicationReplicateReplicaRequest" /> class.
        /// </summary>
        public ReplicationReplicateReplicaRequest()
        {
        }

    }
}
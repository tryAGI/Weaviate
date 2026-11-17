
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Response for the POST /replication/scale endpoint containing the list of initiated shard copy operation IDs.
    /// </summary>
    public sealed partial class ReplicationScaleApplyResponse
    {
        /// <summary>
        /// List of shard copy operation IDs created during scaling.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operationIds")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> OperationIds { get; set; }

        /// <summary>
        /// The unique identifier of the replication scaling plan that generated these operations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("planId")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid PlanId { get; set; }

        /// <summary>
        /// The name of the collection associated with this replication scaling plan.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collection")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Collection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicationScaleApplyResponse" /> class.
        /// </summary>
        /// <param name="operationIds">
        /// List of shard copy operation IDs created during scaling.
        /// </param>
        /// <param name="planId">
        /// The unique identifier of the replication scaling plan that generated these operations.
        /// </param>
        /// <param name="collection">
        /// The name of the collection associated with this replication scaling plan.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReplicationScaleApplyResponse(
            global::System.Collections.Generic.IList<global::System.Guid> operationIds,
            global::System.Guid planId,
            string collection)
        {
            this.OperationIds = operationIds ?? throw new global::System.ArgumentNullException(nameof(operationIds));
            this.PlanId = planId;
            this.Collection = collection ?? throw new global::System.ArgumentNullException(nameof(collection));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicationScaleApplyResponse" /> class.
        /// </summary>
        public ReplicationScaleApplyResponse()
        {
        }

    }
}

#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Contains the unique identifier of a newly created rebalance plan. GET /replication/rebalance reports the plan's progress.
    /// </summary>
    public sealed partial class ReplicationRebalanceCreateResponse
    {
        /// <summary>
        /// The unique identifier (ID) of the rebalance plan.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicationRebalanceCreateResponse" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier (ID) of the rebalance plan.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReplicationRebalanceCreateResponse(
            string? id)
        {
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicationRebalanceCreateResponse" /> class.
        /// </summary>
        public ReplicationRebalanceCreateResponse()
        {
        }

    }
}
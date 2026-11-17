
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// One node's drafting status.
    /// </summary>
    public sealed partial class ReplicationRebalancePlanDraftingItem
    {
        /// <summary>
        /// The name of the node.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("node")]
        public string? Node { get; set; }

        /// <summary>
        /// `REPORTED` once the node has saved and reported its draft, `FAILED` if its drafting failed, and `DRAFTING` otherwise.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weaviate.JsonConverters.ReplicationRebalancePlanDraftingItemStatusJsonConverter))]
        public global::Weaviate.ReplicationRebalancePlanDraftingItemStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicationRebalancePlanDraftingItem" /> class.
        /// </summary>
        /// <param name="node">
        /// The name of the node.
        /// </param>
        /// <param name="status">
        /// `REPORTED` once the node has saved and reported its draft, `FAILED` if its drafting failed, and `DRAFTING` otherwise.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReplicationRebalancePlanDraftingItem(
            string? node,
            global::Weaviate.ReplicationRebalancePlanDraftingItemStatus? status)
        {
            this.Node = node;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReplicationRebalancePlanDraftingItem" /> class.
        /// </summary>
        public ReplicationRebalancePlanDraftingItem()
        {
        }

    }
}

#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Update payload for an existing namespace.
    /// </summary>
    public sealed partial class NamespaceUpdateRequest
    {
        /// <summary>
        /// Cluster nodes to place this namespace's shards on. The list replaces the namespace's home nodes for placements made after the update, and existing shards stay on their nodes. Entries must be distinct current storage candidates, at least `REPLICATION_MINIMUM_FACTOR` of them, and at least the largest replication factor among the namespace's collections. Unlike on create, an empty list does not auto-pick, so a body with neither this nor `home_node` is a 422. List order decides placement. A collection or tenant with replication factor N goes on the first N entries that are storage nodes, so the first of those receives every factor-1 placement. Until every node runs this release, send only home_node: older nodes refuse an update without it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("home_nodes")]
        public global::System.Collections.Generic.IList<string>? HomeNodes { get; set; }

        /// <summary>
        /// Deprecated: use home_nodes. A value is taken as a one-entry `home_nodes`. Sending it with a non-empty `home_nodes` is a 422, even when it equals the first entry.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("home_node")]
        public string? HomeNode { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="NamespaceUpdateRequest" /> class.
        /// </summary>
        /// <param name="homeNodes">
        /// Cluster nodes to place this namespace's shards on. The list replaces the namespace's home nodes for placements made after the update, and existing shards stay on their nodes. Entries must be distinct current storage candidates, at least `REPLICATION_MINIMUM_FACTOR` of them, and at least the largest replication factor among the namespace's collections. Unlike on create, an empty list does not auto-pick, so a body with neither this nor `home_node` is a 422. List order decides placement. A collection or tenant with replication factor N goes on the first N entries that are storage nodes, so the first of those receives every factor-1 placement. Until every node runs this release, send only home_node: older nodes refuse an update without it.
        /// </param>
        /// <param name="homeNode">
        /// Deprecated: use home_nodes. A value is taken as a one-entry `home_nodes`. Sending it with a non-empty `home_nodes` is a 422, even when it equals the first entry.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NamespaceUpdateRequest(
            global::System.Collections.Generic.IList<string>? homeNodes,
            string? homeNode)
        {
            this.HomeNodes = homeNodes;
            this.HomeNode = homeNode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NamespaceUpdateRequest" /> class.
        /// </summary>
        public NamespaceUpdateRequest()
        {
        }

    }
}
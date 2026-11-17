
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Optional body for namespace creation. When neither `home_nodes` nor `home_node` is set, the cluster picks the home nodes.
    /// </summary>
    public sealed partial class NamespaceCreateRequest
    {
        /// <summary>
        /// Optional cluster nodes to place this namespace's shards on. Entries must be distinct current storage candidates, at least `REPLICATION_MINIMUM_FACTOR` of them. When this and `home_node` are both omitted or empty, the cluster picks `REPLICATION_MAXIMUM_FACTOR` nodes, or every storage node when there are fewer. It refuses that create when `REPLICATION_MAXIMUM_FACTOR` is unset or 0 or below, or when there are fewer storage nodes than `REPLICATION_MINIMUM_FACTOR`. List order decides placement. A collection or tenant with replication factor N goes on the first N entries that are storage nodes, so the first of those receives every factor-1 placement. Until every node runs this release, send only home_node: older nodes ignore home_nodes on create and pick a home node themselves.
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
        /// Initializes a new instance of the <see cref="NamespaceCreateRequest" /> class.
        /// </summary>
        /// <param name="homeNodes">
        /// Optional cluster nodes to place this namespace's shards on. Entries must be distinct current storage candidates, at least `REPLICATION_MINIMUM_FACTOR` of them. When this and `home_node` are both omitted or empty, the cluster picks `REPLICATION_MAXIMUM_FACTOR` nodes, or every storage node when there are fewer. It refuses that create when `REPLICATION_MAXIMUM_FACTOR` is unset or 0 or below, or when there are fewer storage nodes than `REPLICATION_MINIMUM_FACTOR`. List order decides placement. A collection or tenant with replication factor N goes on the first N entries that are storage nodes, so the first of those receives every factor-1 placement. Until every node runs this release, send only home_node: older nodes ignore home_nodes on create and pick a home node themselves.
        /// </param>
        /// <param name="homeNode">
        /// Deprecated: use home_nodes. A value is taken as a one-entry `home_nodes`. Sending it with a non-empty `home_nodes` is a 422, even when it equals the first entry.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public NamespaceCreateRequest(
            global::System.Collections.Generic.IList<string>? homeNodes,
            string? homeNode)
        {
            this.HomeNodes = homeNodes;
            this.HomeNode = homeNode;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NamespaceCreateRequest" /> class.
        /// </summary>
        public NamespaceCreateRequest()
        {
        }

    }
}
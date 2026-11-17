
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// A cluster-level namespace used to group resources under a common administrative unit. Namespace names must contain only lowercase letters, digits, and hyphens, must start and end with a letter or digit, must be 3-36 characters long, and must not be a reserved name.
    /// </summary>
    public sealed partial class Namespace
    {
        /// <summary>
        /// The unique name of the namespace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The cluster nodes where this namespace's shards are placed. The list is set at create time and can be updated later. An update applies to future placement decisions only, and existing live shards are not moved. A collection or tenant with replication factor N below the list length is placed on the first N entries that are storage nodes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("home_nodes")]
        public global::System.Collections.Generic.IList<string>? HomeNodes { get; set; }

        /// <summary>
        /// Deprecated: use home_nodes. Holds the first entry of `home_nodes`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("home_node")]
        public string? HomeNode { get; set; }

        /// <summary>
        /// Lifecycle state. "active" namespaces accept all operations. "suspended" namespaces reject new classes, aliases, users, roles, role assignments, and replica movements, and their users can no longer authenticate; everything the namespace already owns is retained. "resuming" namespaces are on their way back to "active" and are still restricted the same way, replica movements included. "deleting" namespaces are being removed: new classes, aliases, users, and replica movements can no longer be created in the namespace, and the namespace itself disappears once removal completes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("state")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weaviate.JsonConverters.NamespaceStateJsonConverter))]
        public global::Weaviate.NamespaceState? State { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Namespace" /> class.
        /// </summary>
        /// <param name="name">
        /// The unique name of the namespace.
        /// </param>
        /// <param name="homeNodes">
        /// The cluster nodes where this namespace's shards are placed. The list is set at create time and can be updated later. An update applies to future placement decisions only, and existing live shards are not moved. A collection or tenant with replication factor N below the list length is placed on the first N entries that are storage nodes.
        /// </param>
        /// <param name="homeNode">
        /// Deprecated: use home_nodes. Holds the first entry of `home_nodes`.
        /// </param>
        /// <param name="state">
        /// Lifecycle state. "active" namespaces accept all operations. "suspended" namespaces reject new classes, aliases, users, roles, role assignments, and replica movements, and their users can no longer authenticate; everything the namespace already owns is retained. "resuming" namespaces are on their way back to "active" and are still restricted the same way, replica movements included. "deleting" namespaces are being removed: new classes, aliases, users, and replica movements can no longer be created in the namespace, and the namespace itself disappears once removal completes.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Namespace(
            string? name,
            global::System.Collections.Generic.IList<string>? homeNodes,
            string? homeNode,
            global::Weaviate.NamespaceState? state)
        {
            this.Name = name;
            this.HomeNodes = homeNodes;
            this.HomeNode = homeNode;
            this.State = state;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Namespace" /> class.
        /// </summary>
        public Namespace()
        {
        }

    }
}

#nullable enable

namespace Weaviate
{
    /// <summary>
    /// permissions attached to a role.
    /// </summary>
    public sealed partial class Permission
    {
        /// <summary>
        /// resources applicable for backup actions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backups")]
        public global::Weaviate.PermissionBackups? Backups { get; set; }

        /// <summary>
        /// resources applicable for data actions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::Weaviate.PermissionData? Data { get; set; }

        /// <summary>
        /// resources applicable for cluster actions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodes")]
        public global::Weaviate.PermissionNodes? Nodes { get; set; }

        /// <summary>
        /// resources applicable for role actions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("roles")]
        public global::Weaviate.PermissionRoles? Roles { get; set; }

        /// <summary>
        /// resources applicable for collection and/or tenant actions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collections")]
        public global::Weaviate.PermissionCollections? Collections { get; set; }

        /// <summary>
        /// allowed actions in weaviate.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("action")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weaviate.JsonConverters.PermissionActionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Weaviate.PermissionAction Action { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Permission" /> class.
        /// </summary>
        /// <param name="backups">
        /// resources applicable for backup actions
        /// </param>
        /// <param name="data">
        /// resources applicable for data actions
        /// </param>
        /// <param name="nodes">
        /// resources applicable for cluster actions
        /// </param>
        /// <param name="roles">
        /// resources applicable for role actions
        /// </param>
        /// <param name="collections">
        /// resources applicable for collection and/or tenant actions
        /// </param>
        /// <param name="action">
        /// allowed actions in weaviate.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public Permission(
            global::Weaviate.PermissionAction action,
            global::Weaviate.PermissionBackups? backups,
            global::Weaviate.PermissionData? data,
            global::Weaviate.PermissionNodes? nodes,
            global::Weaviate.PermissionRoles? roles,
            global::Weaviate.PermissionCollections? collections)
        {
            this.Action = action;
            this.Backups = backups;
            this.Data = data;
            this.Nodes = nodes;
            this.Roles = roles;
            this.Collections = collections;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Permission" /> class.
        /// </summary>
        public Permission()
        {
        }
    }
}

#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Permissions attached to a role.
    /// </summary>
    public sealed partial class Permission
    {
        /// <summary>
        /// Resources applicable for backup actions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("backups")]
        public global::Weaviate.PermissionBackups? Backups { get; set; }

        /// <summary>
        /// Resources applicable for data actions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        public global::Weaviate.PermissionData? Data { get; set; }

        /// <summary>
        /// Resources applicable for cluster actions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("nodes")]
        public global::Weaviate.PermissionNodes? Nodes { get; set; }

        /// <summary>
        /// Resources applicable for user actions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users")]
        public global::Weaviate.PermissionUsers? Users { get; set; }

        /// <summary>
        /// Resources applicable for group actions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groups")]
        public global::Weaviate.PermissionGroups? Groups { get; set; }

        /// <summary>
        /// Resources applicable for tenant actions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenants")]
        public global::Weaviate.PermissionTenants? Tenants { get; set; }

        /// <summary>
        /// Resources applicable for role actions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("roles")]
        public global::Weaviate.PermissionRoles? Roles { get; set; }

        /// <summary>
        /// Resources applicable for collection and/or tenant actions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collections")]
        public global::Weaviate.PermissionCollections? Collections { get; set; }

        /// <summary>
        /// resources applicable for replicate actions
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("replicate")]
        public global::Weaviate.PermissionReplicate? Replicate { get; set; }

        /// <summary>
        /// Resource definition for alias-related actions and permissions. Used to specify which aliases and collections can be accessed or modified.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("aliases")]
        public global::Weaviate.PermissionAliases? Aliases { get; set; }

        /// <summary>
        /// Resources applicable for namespace actions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("namespaces")]
        public global::Weaviate.PermissionNamespaces? Namespaces { get; set; }

        /// <summary>
        /// Allowed actions in weaviate.
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
        /// <param name="action">
        /// Allowed actions in weaviate.
        /// </param>
        /// <param name="backups">
        /// Resources applicable for backup actions.
        /// </param>
        /// <param name="data">
        /// Resources applicable for data actions.
        /// </param>
        /// <param name="nodes">
        /// Resources applicable for cluster actions.
        /// </param>
        /// <param name="users">
        /// Resources applicable for user actions.
        /// </param>
        /// <param name="groups">
        /// Resources applicable for group actions.
        /// </param>
        /// <param name="tenants">
        /// Resources applicable for tenant actions.
        /// </param>
        /// <param name="roles">
        /// Resources applicable for role actions.
        /// </param>
        /// <param name="collections">
        /// Resources applicable for collection and/or tenant actions.
        /// </param>
        /// <param name="replicate">
        /// resources applicable for replicate actions
        /// </param>
        /// <param name="aliases">
        /// Resource definition for alias-related actions and permissions. Used to specify which aliases and collections can be accessed or modified.
        /// </param>
        /// <param name="namespaces">
        /// Resources applicable for namespace actions.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Permission(
            global::Weaviate.PermissionAction action,
            global::Weaviate.PermissionBackups? backups,
            global::Weaviate.PermissionData? data,
            global::Weaviate.PermissionNodes? nodes,
            global::Weaviate.PermissionUsers? users,
            global::Weaviate.PermissionGroups? groups,
            global::Weaviate.PermissionTenants? tenants,
            global::Weaviate.PermissionRoles? roles,
            global::Weaviate.PermissionCollections? collections,
            global::Weaviate.PermissionReplicate? replicate,
            global::Weaviate.PermissionAliases? aliases,
            global::Weaviate.PermissionNamespaces? namespaces)
        {
            this.Backups = backups;
            this.Data = data;
            this.Nodes = nodes;
            this.Users = users;
            this.Groups = groups;
            this.Tenants = tenants;
            this.Roles = roles;
            this.Collections = collections;
            this.Replicate = replicate;
            this.Aliases = aliases;
            this.Namespaces = namespaces;
            this.Action = action;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Permission" /> class.
        /// </summary>
        public Permission()
        {
        }

    }
}
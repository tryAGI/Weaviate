
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Resources applicable for role actions.
    /// </summary>
    public sealed partial class PermissionRoles
    {
        /// <summary>
        /// A string that specifies which roles this permission applies to. Can be an exact role name or a regex pattern. The default value `*` applies the permission to all roles. Must be at most 256 bytes, must not contain '/', and must be a valid regex pattern. Creating a role or adding permissions also refuses ',', '"' and control characters.<br/>
        /// Default Value: *
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string? Role { get; set; }

        /// <summary>
        /// Set the scope for the manage role permission.<br/>
        /// Default Value: match
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scope")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weaviate.JsonConverters.PermissionRolesScopeJsonConverter))]
        public global::Weaviate.PermissionRolesScope? Scope { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionRoles" /> class.
        /// </summary>
        /// <param name="role">
        /// A string that specifies which roles this permission applies to. Can be an exact role name or a regex pattern. The default value `*` applies the permission to all roles. Must be at most 256 bytes, must not contain '/', and must be a valid regex pattern. Creating a role or adding permissions also refuses ',', '"' and control characters.<br/>
        /// Default Value: *
        /// </param>
        /// <param name="scope">
        /// Set the scope for the manage role permission.<br/>
        /// Default Value: match
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PermissionRoles(
            string? role,
            global::Weaviate.PermissionRolesScope? scope)
        {
            this.Role = role;
            this.Scope = scope;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionRoles" /> class.
        /// </summary>
        public PermissionRoles()
        {
        }

    }
}
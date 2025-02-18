
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// resources applicable for role actions
    /// </summary>
    public sealed partial class PermissionRoles
    {
        /// <summary>
        /// string or regex. if a specific role name, if left empty it will be ALL or *<br/>
        /// Default Value: *
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string? Role { get; set; }

        /// <summary>
        /// set the scope for the manage role permission<br/>
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
        /// string or regex. if a specific role name, if left empty it will be ALL or *<br/>
        /// Default Value: *
        /// </param>
        /// <param name="scope">
        /// set the scope for the manage role permission<br/>
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
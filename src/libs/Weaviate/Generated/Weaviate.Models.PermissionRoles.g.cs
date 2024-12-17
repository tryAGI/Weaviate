
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
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PermissionRoles(
            string? role)
        {
            this.Role = role;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionRoles" /> class.
        /// </summary>
        public PermissionRoles()
        {
        }
    }
}
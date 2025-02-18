
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class RevokeRoleFromGroupRequest
    {
        /// <summary>
        /// the roles that revoked from group
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("roles")]
        public global::System.Collections.Generic.IList<string>? Roles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RevokeRoleFromGroupRequest" /> class.
        /// </summary>
        /// <param name="roles">
        /// the roles that revoked from group
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RevokeRoleFromGroupRequest(
            global::System.Collections.Generic.IList<string>? roles)
        {
            this.Roles = roles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RevokeRoleFromGroupRequest" /> class.
        /// </summary>
        public RevokeRoleFromGroupRequest()
        {
        }
    }
}

#nullable enable

namespace Weaviate
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AssignRoleToUserRequest
    {
        /// <summary>
        /// the roles that assigned to user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("roles")]
        public global::System.Collections.Generic.IList<string>? Roles { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssignRoleToUserRequest" /> class.
        /// </summary>
        /// <param name="roles">
        /// the roles that assigned to user
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssignRoleToUserRequest(
            global::System.Collections.Generic.IList<string>? roles)
        {
            this.Roles = roles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssignRoleToUserRequest" /> class.
        /// </summary>
        public AssignRoleToUserRequest()
        {
        }
    }
}

#nullable enable

namespace Weaviate
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class AssignRoleToGroupRequest
    {
        /// <summary>
        /// The roles to assign to the specified group.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("roles")]
        public global::System.Collections.Generic.IList<string>? Roles { get; set; }

        /// <summary>
        /// If the group contains OIDC or database users.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groupType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weaviate.JsonConverters.GroupTypeJsonConverter))]
        public global::Weaviate.GroupType? GroupType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssignRoleToGroupRequest" /> class.
        /// </summary>
        /// <param name="roles">
        /// The roles to assign to the specified group.
        /// </param>
        /// <param name="groupType">
        /// If the group contains OIDC or database users.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssignRoleToGroupRequest(
            global::System.Collections.Generic.IList<string>? roles,
            global::Weaviate.GroupType? groupType)
        {
            this.Roles = roles;
            this.GroupType = groupType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssignRoleToGroupRequest" /> class.
        /// </summary>
        public AssignRoleToGroupRequest()
        {
        }

    }
}
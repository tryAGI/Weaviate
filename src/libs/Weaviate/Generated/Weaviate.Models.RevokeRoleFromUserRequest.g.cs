
#nullable enable

namespace Weaviate
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class RevokeRoleFromUserRequest
    {
        /// <summary>
        /// The roles to revoke from the specified user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("roles")]
        public global::System.Collections.Generic.IList<string>? Roles { get; set; }

        /// <summary>
        /// The type of the user. `db` users are managed by Weaviate, `oidc` users are managed by an external OIDC provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weaviate.JsonConverters.UserTypeInputJsonConverter))]
        public global::Weaviate.UserTypeInput? UserType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RevokeRoleFromUserRequest" /> class.
        /// </summary>
        /// <param name="roles">
        /// The roles to revoke from the specified user.
        /// </param>
        /// <param name="userType">
        /// The type of the user. `db` users are managed by Weaviate, `oidc` users are managed by an external OIDC provider.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RevokeRoleFromUserRequest(
            global::System.Collections.Generic.IList<string>? roles,
            global::Weaviate.UserTypeInput? userType)
        {
            this.Roles = roles;
            this.UserType = userType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RevokeRoleFromUserRequest" /> class.
        /// </summary>
        public RevokeRoleFromUserRequest()
        {
        }

    }
}
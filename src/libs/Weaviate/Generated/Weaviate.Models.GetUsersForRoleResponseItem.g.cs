
#nullable enable

namespace Weaviate
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class GetUsersForRoleResponseItem
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userId")]
        public string? UserId { get; set; }

        /// <summary>
        /// The type of the user. `db_user` users are created through the `users` API, `db_env_user` users are created through environment variables, and `oidc` users are managed by an external OIDC provider.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("userType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weaviate.JsonConverters.UserTypeOutputJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::Weaviate.UserTypeOutput UserType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsersForRoleResponseItem" /> class.
        /// </summary>
        /// <param name="userType">
        /// The type of the user. `db_user` users are created through the `users` API, `db_env_user` users are created through environment variables, and `oidc` users are managed by an external OIDC provider.
        /// </param>
        /// <param name="userId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GetUsersForRoleResponseItem(
            global::Weaviate.UserTypeOutput userType,
            string? userId)
        {
            this.UserId = userId;
            this.UserType = userType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetUsersForRoleResponseItem" /> class.
        /// </summary>
        public GetUsersForRoleResponseItem()
        {
        }

    }
}

#nullable enable

namespace Weaviate
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UserOwnInfo
    {
        /// <summary>
        /// Date and time in ISO 8601 format, in UTC, at which the caller's API key stops authenticating. Absent means the key never expires, the caller is not a DB user, or DB user management is disabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expiresAt")]
        public global::System.DateTime? ExpiresAt { get; set; }

        /// <summary>
        /// The groups associated with the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groups")]
        public global::System.Collections.Generic.IList<string>? Groups { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("roles")]
        public global::System.Collections.Generic.IList<global::Weaviate.Role>? Roles { get; set; }

        /// <summary>
        /// The name (ID) of the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("username")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Username { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserOwnInfo" /> class.
        /// </summary>
        /// <param name="username">
        /// The name (ID) of the user.
        /// </param>
        /// <param name="expiresAt">
        /// Date and time in ISO 8601 format, in UTC, at which the caller's API key stops authenticating. Absent means the key never expires, the caller is not a DB user, or DB user management is disabled.
        /// </param>
        /// <param name="groups">
        /// The groups associated with the user.
        /// </param>
        /// <param name="roles"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserOwnInfo(
            string username,
            global::System.DateTime? expiresAt,
            global::System.Collections.Generic.IList<string>? groups,
            global::System.Collections.Generic.IList<global::Weaviate.Role>? roles)
        {
            this.ExpiresAt = expiresAt;
            this.Groups = groups;
            this.Roles = roles;
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserOwnInfo" /> class.
        /// </summary>
        public UserOwnInfo()
        {
        }

    }
}

#nullable enable

namespace Weaviate
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UserInfo
    {
        /// <summary>
        /// The groups associated to the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groups")]
        public global::System.Collections.Generic.IList<string>? Groups { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("roles")]
        public global::System.Collections.Generic.IList<global::Weaviate.Role>? Roles { get; set; }

        /// <summary>
        /// The username associated with the provided key
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
        /// Initializes a new instance of the <see cref="UserInfo" /> class.
        /// </summary>
        /// <param name="groups">
        /// The groups associated to the user
        /// </param>
        /// <param name="roles"></param>
        /// <param name="username">
        /// The username associated with the provided key
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserInfo(
            string username,
            global::System.Collections.Generic.IList<string>? groups,
            global::System.Collections.Generic.IList<global::Weaviate.Role>? roles)
        {
            this.Username = username ?? throw new global::System.ArgumentNullException(nameof(username));
            this.Groups = groups;
            this.Roles = roles;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserInfo" /> class.
        /// </summary>
        public UserInfo()
        {
        }
    }
}
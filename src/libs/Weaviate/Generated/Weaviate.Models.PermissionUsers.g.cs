
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Resources applicable for user actions.
    /// </summary>
    public sealed partial class PermissionUsers
    {
        /// <summary>
        /// A string that specifies which users this permission applies to. Can be an exact user name or a regex pattern. The default value `*` applies the permission to all users. Must be at most 256 bytes, must not contain '/', and must be a valid regex pattern. Creating a role or adding permissions also refuses ',', '"' and control characters.<br/>
        /// Default Value: *
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("users")]
        public string? Users { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionUsers" /> class.
        /// </summary>
        /// <param name="users">
        /// A string that specifies which users this permission applies to. Can be an exact user name or a regex pattern. The default value `*` applies the permission to all users. Must be at most 256 bytes, must not contain '/', and must be a valid regex pattern. Creating a role or adding permissions also refuses ',', '"' and control characters.<br/>
        /// Default Value: *
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PermissionUsers(
            string? users)
        {
            this.Users = users;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionUsers" /> class.
        /// </summary>
        public PermissionUsers()
        {
        }

    }
}
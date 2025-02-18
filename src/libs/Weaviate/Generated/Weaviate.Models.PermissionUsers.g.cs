
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// resources applicable for user actions
    /// </summary>
    public sealed partial class PermissionUsers
    {
        /// <summary>
        /// string or regex. if a specific name, if left empty it will be ALL or *<br/>
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
        /// string or regex. if a specific name, if left empty it will be ALL or *<br/>
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

#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Resources applicable for group actions.
    /// </summary>
    public sealed partial class PermissionGroups
    {
        /// <summary>
        /// A string that specifies which groups this permission applies to. Can be an exact group name or a regex pattern. The default value `*` applies the permission to all groups. Must be at most 256 bytes, must not contain '/', and must be a valid regex pattern. Creating a role or adding permissions also refuses ',', '"' and control characters.<br/>
        /// Default Value: *
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group")]
        public string? Group { get; set; }

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
        /// Initializes a new instance of the <see cref="PermissionGroups" /> class.
        /// </summary>
        /// <param name="group">
        /// A string that specifies which groups this permission applies to. Can be an exact group name or a regex pattern. The default value `*` applies the permission to all groups. Must be at most 256 bytes, must not contain '/', and must be a valid regex pattern. Creating a role or adding permissions also refuses ',', '"' and control characters.<br/>
        /// Default Value: *
        /// </param>
        /// <param name="groupType">
        /// If the group contains OIDC or database users.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PermissionGroups(
            string? group,
            global::Weaviate.GroupType? groupType)
        {
            this.Group = group;
            this.GroupType = groupType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionGroups" /> class.
        /// </summary>
        public PermissionGroups()
        {
        }

    }
}

#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Resource definition for alias-related actions and permissions. Used to specify which aliases and collections can be accessed or modified.
    /// </summary>
    public sealed partial class PermissionAliases
    {
        /// <summary>
        /// A string that specifies which collections this permission applies to. Can be an exact collection name or a regex pattern. The default value `*` applies the permission to all collections.<br/>
        /// Default Value: *
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collection")]
        public string? Collection { get; set; }

        /// <summary>
        /// A string that specifies which aliases this permission applies to. Can be an exact alias name or a regex pattern. The default value `*` applies the permission to all aliases. Must be at most 256 bytes, must not contain '/', and must be a valid regex pattern. Creating a role or adding permissions also refuses ',', '"' and control characters.<br/>
        /// Default Value: *
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alias")]
        public string? Alias { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionAliases" /> class.
        /// </summary>
        /// <param name="collection">
        /// A string that specifies which collections this permission applies to. Can be an exact collection name or a regex pattern. The default value `*` applies the permission to all collections.<br/>
        /// Default Value: *
        /// </param>
        /// <param name="alias">
        /// A string that specifies which aliases this permission applies to. Can be an exact alias name or a regex pattern. The default value `*` applies the permission to all aliases. Must be at most 256 bytes, must not contain '/', and must be a valid regex pattern. Creating a role or adding permissions also refuses ',', '"' and control characters.<br/>
        /// Default Value: *
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PermissionAliases(
            string? collection,
            string? alias)
        {
            this.Collection = collection;
            this.Alias = alias;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionAliases" /> class.
        /// </summary>
        public PermissionAliases()
        {
        }

    }
}
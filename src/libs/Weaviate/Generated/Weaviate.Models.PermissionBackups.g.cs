
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Resources applicable for backup actions.
    /// </summary>
    public sealed partial class PermissionBackups
    {
        /// <summary>
        /// A string that specifies which collections this permission applies to. Can be an exact collection name or a regex pattern. The default value `*` applies the permission to all collections.<br/>
        /// Default Value: *
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collection")]
        public string? Collection { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionBackups" /> class.
        /// </summary>
        /// <param name="collection">
        /// A string that specifies which collections this permission applies to. Can be an exact collection name or a regex pattern. The default value `*` applies the permission to all collections.<br/>
        /// Default Value: *
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PermissionBackups(
            string? collection)
        {
            this.Collection = collection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionBackups" /> class.
        /// </summary>
        public PermissionBackups()
        {
        }

    }
}
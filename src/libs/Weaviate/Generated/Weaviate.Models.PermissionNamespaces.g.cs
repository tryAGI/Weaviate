
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Resources applicable for namespace actions.
    /// </summary>
    public sealed partial class PermissionNamespaces
    {
        /// <summary>
        /// A string that specifies which namespaces this permission applies to. Can be an exact namespace name or a regex pattern. The default value `*` applies the permission to all namespaces. Must be at most 256 bytes, must not contain '/', and must be a valid regex pattern. Creating a role or adding permissions also refuses ',', '"' and control characters.<br/>
        /// Default Value: *
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("namespace")]
        public string? Namespace { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionNamespaces" /> class.
        /// </summary>
        /// <param name="namespace">
        /// A string that specifies which namespaces this permission applies to. Can be an exact namespace name or a regex pattern. The default value `*` applies the permission to all namespaces. Must be at most 256 bytes, must not contain '/', and must be a valid regex pattern. Creating a role or adding permissions also refuses ',', '"' and control characters.<br/>
        /// Default Value: *
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PermissionNamespaces(
            string? @namespace)
        {
            this.Namespace = @namespace;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionNamespaces" /> class.
        /// </summary>
        public PermissionNamespaces()
        {
        }

    }
}
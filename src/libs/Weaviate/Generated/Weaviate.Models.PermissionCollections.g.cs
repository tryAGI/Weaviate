
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// resources applicable for collection and/or tenant actions
    /// </summary>
    public sealed partial class PermissionCollections
    {
        /// <summary>
        /// string or regex. if a specific collection name, if left empty it will be ALL or *<br/>
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
        /// Initializes a new instance of the <see cref="PermissionCollections" /> class.
        /// </summary>
        /// <param name="collection">
        /// string or regex. if a specific collection name, if left empty it will be ALL or *<br/>
        /// Default Value: *
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PermissionCollections(
            string? collection)
        {
            this.Collection = collection;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionCollections" /> class.
        /// </summary>
        public PermissionCollections()
        {
        }
    }
}
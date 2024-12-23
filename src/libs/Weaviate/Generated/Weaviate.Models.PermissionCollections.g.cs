
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
        /// string or regex. if a specific tenant name, if left empty it will be ALL or *<br/>
        /// Default Value: *
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant")]
        public string? Tenant { get; set; }

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
        /// <param name="tenant">
        /// string or regex. if a specific tenant name, if left empty it will be ALL or *<br/>
        /// Default Value: *
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public PermissionCollections(
            string? collection,
            string? tenant)
        {
            this.Collection = collection;
            this.Tenant = tenant;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionCollections" /> class.
        /// </summary>
        public PermissionCollections()
        {
        }
    }
}
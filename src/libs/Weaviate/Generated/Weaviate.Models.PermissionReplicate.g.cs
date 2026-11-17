
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// resources applicable for replicate actions
    /// </summary>
    public sealed partial class PermissionReplicate
    {
        /// <summary>
        /// string or regex. if a specific collection name, if left empty it will be ALL or *<br/>
        /// Default Value: *
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collection")]
        public string? Collection { get; set; }

        /// <summary>
        /// string or regex. if a specific shard name, if left empty it will be ALL or *. Must be at most 256 bytes, must not contain '/', and must be a valid regex pattern. Creating a role or adding permissions also refuses ',', '"' and control characters.<br/>
        /// Default Value: *
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("shard")]
        public string? Shard { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionReplicate" /> class.
        /// </summary>
        /// <param name="collection">
        /// string or regex. if a specific collection name, if left empty it will be ALL or *<br/>
        /// Default Value: *
        /// </param>
        /// <param name="shard">
        /// string or regex. if a specific shard name, if left empty it will be ALL or *. Must be at most 256 bytes, must not contain '/', and must be a valid regex pattern. Creating a role or adding permissions also refuses ',', '"' and control characters.<br/>
        /// Default Value: *
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PermissionReplicate(
            string? collection,
            string? shard)
        {
            this.Collection = collection;
            this.Shard = shard;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PermissionReplicate" /> class.
        /// </summary>
        public PermissionReplicate()
        {
        }

    }
}

#nullable enable

namespace Weaviate
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class IndexStatusResponse
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collection")]
        public string? Collection { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        public global::System.Collections.Generic.IList<global::Weaviate.PropertyIndexStatus>? Properties { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexStatusResponse" /> class.
        /// </summary>
        /// <param name="collection"></param>
        /// <param name="properties"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public IndexStatusResponse(
            string? collection,
            global::System.Collections.Generic.IList<global::Weaviate.PropertyIndexStatus>? properties)
        {
            this.Collection = collection;
            this.Properties = properties;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="IndexStatusResponse" /> class.
        /// </summary>
        public IndexStatusResponse()
        {
        }

    }
}
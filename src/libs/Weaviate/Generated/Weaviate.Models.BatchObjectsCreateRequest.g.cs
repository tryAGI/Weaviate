
#nullable enable

namespace Weaviate
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class BatchObjectsCreateRequest
    {
        /// <summary>
        /// Controls which fields are returned in the response for each object. Default is `ALL`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fields")]
        public global::System.Collections.Generic.IList<global::Weaviate.BatchObjectsCreateRequestField>? Fields { get; set; }

        /// <summary>
        /// Array of objects to be created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("objects")]
        public global::System.Collections.Generic.IList<global::Weaviate.Object>? Objects { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchObjectsCreateRequest" /> class.
        /// </summary>
        /// <param name="fields">
        /// Controls which fields are returned in the response for each object. Default is `ALL`.
        /// </param>
        /// <param name="objects">
        /// Array of objects to be created.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BatchObjectsCreateRequest(
            global::System.Collections.Generic.IList<global::Weaviate.BatchObjectsCreateRequestField>? fields,
            global::System.Collections.Generic.IList<global::Weaviate.Object>? objects)
        {
            this.Fields = fields;
            this.Objects = objects;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BatchObjectsCreateRequest" /> class.
        /// </summary>
        public BatchObjectsCreateRequest()
        {
        }

    }
}

#nullable enable

namespace Weaviate
{
    /// <summary>
    /// A single search hit: the object's `id` (always returned), the selected non-reference properties under `properties`, the selected cross-references under `references`, and the requested retrieval metadata under `metadata`.
    /// </summary>
    public sealed partial class SearchResultObject
    {
        /// <summary>
        /// The object's UUID. Always returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Guid Id { get; set; }

        /// <summary>
        /// The selected non-reference properties of the object; nested (object / object[]) properties are pruned to the selected nested fields. Always present — `{}` when the request selects no properties.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Weaviate.JsonObject> Properties { get; set; }

        /// <summary>
        /// The selected cross-references: reference property name to the array of referenced objects. Omitted when the request selects no references, or when the hit has no entry for any of the selected references.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("references")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Weaviate.SearchResultReference>>? References { get; set; }

        /// <summary>
        /// The retrieval metadata of a single search hit, populated according to `returnMetadata`. Every field is optional and only present when it was requested and is computable for the search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Weaviate.SearchResultMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultObject" /> class.
        /// </summary>
        /// <param name="id">
        /// The object's UUID. Always returned.
        /// </param>
        /// <param name="properties">
        /// The selected non-reference properties of the object; nested (object / object[]) properties are pruned to the selected nested fields. Always present — `{}` when the request selects no properties.
        /// </param>
        /// <param name="references">
        /// The selected cross-references: reference property name to the array of referenced objects. Omitted when the request selects no references, or when the hit has no entry for any of the selected references.
        /// </param>
        /// <param name="metadata">
        /// The retrieval metadata of a single search hit, populated according to `returnMetadata`. Every field is optional and only present when it was requested and is computable for the search.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchResultObject(
            global::System.Guid id,
            global::System.Collections.Generic.Dictionary<string, global::Weaviate.JsonObject> properties,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Weaviate.SearchResultReference>>? references,
            global::Weaviate.SearchResultMetadata? metadata)
        {
            this.Id = id;
            this.Properties = properties ?? throw new global::System.ArgumentNullException(nameof(properties));
            this.References = references;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultObject" /> class.
        /// </summary>
        public SearchResultObject()
        {
        }

    }
}
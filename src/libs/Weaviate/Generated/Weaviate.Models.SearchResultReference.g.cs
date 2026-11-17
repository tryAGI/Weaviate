
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// One referenced object: the selected non-reference properties under `properties`, deeper cross-references under `references`, and the requested metadata under `metadata`.
    /// </summary>
    public sealed partial class SearchResultReference
    {
        /// <summary>
        /// The collection the referenced object belongs to. Returned for multi-target references.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("collection")]
        public string? Collection { get; set; }

        /// <summary>
        /// The selected non-reference properties of the referenced object; nested (object / object[]) properties are pruned to the selected nested fields. Always present — `{}` when the selector selects no properties.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("properties")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.Dictionary<string, global::Weaviate.JsonObject> Properties { get; set; }

        /// <summary>
        /// The cross-references selected one hop deeper. Omitted when the selector selects none, or when the referenced object has no entry for any of them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("references")]
        public global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Weaviate.SearchResultReference>>? References { get; set; }

        /// <summary>
        /// The metadata of a referenced object, populated according to the selector's `returnMetadata`. Every field is optional and only present when it was requested.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::Weaviate.SearchResultReferenceMetadata? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultReference" /> class.
        /// </summary>
        /// <param name="properties">
        /// The selected non-reference properties of the referenced object; nested (object / object[]) properties are pruned to the selected nested fields. Always present — `{}` when the selector selects no properties.
        /// </param>
        /// <param name="collection">
        /// The collection the referenced object belongs to. Returned for multi-target references.
        /// </param>
        /// <param name="references">
        /// The cross-references selected one hop deeper. Omitted when the selector selects none, or when the referenced object has no entry for any of them.
        /// </param>
        /// <param name="metadata">
        /// The metadata of a referenced object, populated according to the selector's `returnMetadata`. Every field is optional and only present when it was requested.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchResultReference(
            global::System.Collections.Generic.Dictionary<string, global::Weaviate.JsonObject> properties,
            string? collection,
            global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.IList<global::Weaviate.SearchResultReference>>? references,
            global::Weaviate.SearchResultReferenceMetadata? metadata)
        {
            this.Collection = collection;
            this.Properties = properties ?? throw new global::System.ArgumentNullException(nameof(properties));
            this.References = references;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultReference" /> class.
        /// </summary>
        public SearchResultReference()
        {
        }

    }
}
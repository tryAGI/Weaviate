
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Selects one cross-reference to return, and what to return from each referenced object.
    /// </summary>
    public sealed partial class SearchReferenceSelector
    {
        /// <summary>
        /// The reference property to follow.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("linkOn")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LinkOn { get; set; }

        /// <summary>
        /// The referenced collection to select. Required when `linkOn` is a multi-target reference.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetCollection")]
        public string? TargetCollection { get; set; }

        /// <summary>
        /// The non-reference properties to return from each referenced object. Omitted returns all non-reference, non-blob properties of the referenced collection; an empty array returns no properties.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("returnProperties")]
        public global::System.Collections.Generic.IList<string>? ReturnProperties { get; set; }

        /// <summary>
        /// The metadata to return under each referenced object's `metadata` key. Omitted or empty returns no `metadata` block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("returnMetadata")]
        public global::System.Collections.Generic.IList<global::Weaviate.SearchReferenceSelectorReturnMetadataItem>? ReturnMetadata { get; set; }

        /// <summary>
        /// The cross-references to return from each referenced object. Nesting deeper than `QUERY_CROSS_REFERENCE_DEPTH_LIMIT` is rejected.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("returnReferences")]
        public global::System.Collections.Generic.IList<global::Weaviate.SearchReferenceSelector>? ReturnReferences { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchReferenceSelector" /> class.
        /// </summary>
        /// <param name="linkOn">
        /// The reference property to follow.
        /// </param>
        /// <param name="targetCollection">
        /// The referenced collection to select. Required when `linkOn` is a multi-target reference.
        /// </param>
        /// <param name="returnProperties">
        /// The non-reference properties to return from each referenced object. Omitted returns all non-reference, non-blob properties of the referenced collection; an empty array returns no properties.
        /// </param>
        /// <param name="returnMetadata">
        /// The metadata to return under each referenced object's `metadata` key. Omitted or empty returns no `metadata` block.
        /// </param>
        /// <param name="returnReferences">
        /// The cross-references to return from each referenced object. Nesting deeper than `QUERY_CROSS_REFERENCE_DEPTH_LIMIT` is rejected.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchReferenceSelector(
            string linkOn,
            string? targetCollection,
            global::System.Collections.Generic.IList<string>? returnProperties,
            global::System.Collections.Generic.IList<global::Weaviate.SearchReferenceSelectorReturnMetadataItem>? returnMetadata,
            global::System.Collections.Generic.IList<global::Weaviate.SearchReferenceSelector>? returnReferences)
        {
            this.LinkOn = linkOn ?? throw new global::System.ArgumentNullException(nameof(linkOn));
            this.TargetCollection = targetCollection;
            this.ReturnProperties = returnProperties;
            this.ReturnMetadata = returnMetadata;
            this.ReturnReferences = returnReferences;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchReferenceSelector" /> class.
        /// </summary>
        public SearchReferenceSelector()
        {
        }

    }
}
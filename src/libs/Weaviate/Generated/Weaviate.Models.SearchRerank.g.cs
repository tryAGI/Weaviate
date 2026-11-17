
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// Reserved for reranking. Returns 422 (not yet supported).
    /// </summary>
    public sealed partial class SearchRerank
    {
        /// <summary>
        /// The property to rerank on.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("property")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Property { get; set; }

        /// <summary>
        /// The query to rerank with. Defaults to the search query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        public string? Query { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRerank" /> class.
        /// </summary>
        /// <param name="property">
        /// The property to rerank on.
        /// </param>
        /// <param name="query">
        /// The query to rerank with. Defaults to the search query.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchRerank(
            string property,
            string? query)
        {
            this.Property = property ?? throw new global::System.ArgumentNullException(nameof(property));
            this.Query = query;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchRerank" /> class.
        /// </summary>
        public SearchRerank()
        {
        }

    }
}
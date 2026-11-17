
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// The result of a REST search: the matched objects as `{id, properties, references, metadata}` envelopes, plus the server-side processing time. Shared by all REST search endpoints.
    /// </summary>
    public sealed partial class SearchResponse
    {
        /// <summary>
        /// The matched objects, ordered by relevance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::Weaviate.SearchResultObject> Results { get; set; }

        /// <summary>
        /// Server-side processing time in milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tookMs")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long TookMs { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResponse" /> class.
        /// </summary>
        /// <param name="results">
        /// The matched objects, ordered by relevance.
        /// </param>
        /// <param name="tookMs">
        /// Server-side processing time in milliseconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchResponse(
            global::System.Collections.Generic.IList<global::Weaviate.SearchResultObject> results,
            long tookMs)
        {
            this.Results = results ?? throw new global::System.ArgumentNullException(nameof(results));
            this.TookMs = tookMs;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResponse" /> class.
        /// </summary>
        public SearchResponse()
        {
        }

    }
}

#nullable enable

namespace Weaviate
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SearchHybridRequestVariant2
    {
        /// <summary>
        /// The query, as a plain string. It is scored with BM25F for the keyword part of the search and vectorized server-side for the vector part, unless `vector` is supplied. Must not be empty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("query")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Query { get; set; }

        /// <summary>
        /// The weight of the vector part of the search, between 0 and 1. `0` is a pure keyword search, `1` a pure vector search. Omitted defaults to `0.75`. With `0`, or with `vector` supplied, the query is never vectorized, so a collection without a vectorizer module is searchable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("alpha")]
        public double? Alpha { get; set; }

        /// <summary>
        /// The algorithm that fuses the keyword and vector rankings: `ranked` (reciprocal-rank fusion) or `relativeScore` (normalized-score fusion). Omitted defaults to `relativeScore`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("fusionType")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::Weaviate.JsonConverters.SearchHybridRequestVariant2FusionTypeJsonConverter))]
        public global::Weaviate.SearchHybridRequestVariant2FusionType? FusionType { get; set; }

        /// <summary>
        /// The maximum vector distance of a match: objects farther than this from the query vector are excluded, from the keyword ranking too.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("maxVectorDistance")]
        public double? MaxVectorDistance { get; set; }

        /// <summary>
        /// The properties the keyword part of the search scores against, each optionally weighted with a `^boost` suffix (e.g. `title^2`). Omitted or empty searches every searchable text property. A property without a searchable index is rejected with 422.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queryProperties")]
        public global::System.Collections.Generic.IList<string>? QueryProperties { get; set; }

        /// <summary>
        /// The named vector to search. Required when the collection has more than one named vector.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("targetVector")]
        public string? TargetVector { get; set; }

        /// <summary>
        /// The query vector for the vector part of the search, used instead of vectorizing `query`. A non-empty array of numbers that fit a 32-bit float, e.g. `[0.12, -0.3, 0.98]`. It must have the dimensionality of the vector space it is searched against, that is of the collection's (target) vector. Requires `alpha` &gt; 0.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("vector")]
        public object? Vector { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchHybridRequestVariant2" /> class.
        /// </summary>
        /// <param name="query">
        /// The query, as a plain string. It is scored with BM25F for the keyword part of the search and vectorized server-side for the vector part, unless `vector` is supplied. Must not be empty.
        /// </param>
        /// <param name="alpha">
        /// The weight of the vector part of the search, between 0 and 1. `0` is a pure keyword search, `1` a pure vector search. Omitted defaults to `0.75`. With `0`, or with `vector` supplied, the query is never vectorized, so a collection without a vectorizer module is searchable.
        /// </param>
        /// <param name="fusionType">
        /// The algorithm that fuses the keyword and vector rankings: `ranked` (reciprocal-rank fusion) or `relativeScore` (normalized-score fusion). Omitted defaults to `relativeScore`.
        /// </param>
        /// <param name="maxVectorDistance">
        /// The maximum vector distance of a match: objects farther than this from the query vector are excluded, from the keyword ranking too.
        /// </param>
        /// <param name="queryProperties">
        /// The properties the keyword part of the search scores against, each optionally weighted with a `^boost` suffix (e.g. `title^2`). Omitted or empty searches every searchable text property. A property without a searchable index is rejected with 422.
        /// </param>
        /// <param name="targetVector">
        /// The named vector to search. Required when the collection has more than one named vector.
        /// </param>
        /// <param name="vector">
        /// The query vector for the vector part of the search, used instead of vectorizing `query`. A non-empty array of numbers that fit a 32-bit float, e.g. `[0.12, -0.3, 0.98]`. It must have the dimensionality of the vector space it is searched against, that is of the collection's (target) vector. Requires `alpha` &gt; 0.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchHybridRequestVariant2(
            string query,
            double? alpha,
            global::Weaviate.SearchHybridRequestVariant2FusionType? fusionType,
            double? maxVectorDistance,
            global::System.Collections.Generic.IList<string>? queryProperties,
            string? targetVector,
            object? vector)
        {
            this.Query = query ?? throw new global::System.ArgumentNullException(nameof(query));
            this.Alpha = alpha;
            this.FusionType = fusionType;
            this.MaxVectorDistance = maxVectorDistance;
            this.QueryProperties = queryProperties;
            this.TargetVector = targetVector;
            this.Vector = vector;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchHybridRequestVariant2" /> class.
        /// </summary>
        public SearchHybridRequestVariant2()
        {
        }

    }
}
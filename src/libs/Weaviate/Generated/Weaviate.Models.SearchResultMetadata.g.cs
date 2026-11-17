
#nullable enable

namespace Weaviate
{
    /// <summary>
    /// The retrieval metadata of a single search hit, populated according to `returnMetadata`. Every field is optional and only present when it was requested and is computable for the search.
    /// </summary>
    public sealed partial class SearchResultMetadata
    {
        /// <summary>
        /// The vector distance between the hit and the query.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("distance")]
        public float? Distance { get; set; }

        /// <summary>
        /// The normalized certainty of the hit. Only computable on cosine-distance vector indexes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("certainty")]
        public double? Certainty { get; set; }

        /// <summary>
        /// The relevance score of the hit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        public float? Score { get; set; }

        /// <summary>
        /// An explanation of how the score was computed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("explainScore")]
        public string? ExplainScore { get; set; }

        /// <summary>
        /// The object's creation time, as epoch milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("creationTime")]
        public long? CreationTime { get; set; }

        /// <summary>
        /// The object's last-update time, as epoch milliseconds.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lastUpdateTime")]
        public long? LastUpdateTime { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultMetadata" /> class.
        /// </summary>
        /// <param name="distance">
        /// The vector distance between the hit and the query.
        /// </param>
        /// <param name="certainty">
        /// The normalized certainty of the hit. Only computable on cosine-distance vector indexes.
        /// </param>
        /// <param name="score">
        /// The relevance score of the hit.
        /// </param>
        /// <param name="explainScore">
        /// An explanation of how the score was computed.
        /// </param>
        /// <param name="creationTime">
        /// The object's creation time, as epoch milliseconds.
        /// </param>
        /// <param name="lastUpdateTime">
        /// The object's last-update time, as epoch milliseconds.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SearchResultMetadata(
            float? distance,
            double? certainty,
            float? score,
            string? explainScore,
            long? creationTime,
            long? lastUpdateTime)
        {
            this.Distance = distance;
            this.Certainty = certainty;
            this.Score = score;
            this.ExplainScore = explainScore;
            this.CreationTime = creationTime;
            this.LastUpdateTime = lastUpdateTime;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SearchResultMetadata" /> class.
        /// </summary>
        public SearchResultMetadata()
        {
        }

    }
}